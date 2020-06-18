using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using ZTn.Json.JsonTreeView.Extensions;

namespace ZTn.Json.JsonTreeView.Views
{
    public partial class JTokenTreeView : TreeView
    {
        #region >> Fields

        JTokenTreeNode lastDragDropTarget;
        DateTime lastDragOverDateTime;
        Color lastDragDropTargetBackColor;
        readonly TimeSpan dragDropExpandDelay = new TimeSpan(5000000);

        #endregion

        #region >> Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public JTokenTreeView()
        {
            InitializeComponent();

            ItemDrag += ItemDragHandler;
            DragEnter += DragEnterHandler;
            DragDrop += DragDropHandler;
            DragOver += DragOverHandler;
        }

        #endregion

        #region >> TreeView

        /// <inheritdoc />
        /// <remarks>
        /// Style change disabling automatic creation of tooltip on each node of the TreeView (no other C# way of doing this).
        /// </remarks>
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.Style |= 0x80;    // Turn on TVS_NOTOOLTIPS
                return cp;
            }
        }

        #endregion

        private void ItemDragHandler(object sender, ItemDragEventArgs e)
        {
            var sourceNode = e.Item as JTokenTreeNode;

            if (sourceNode == null)
            {
                return;
            }

            DoDragDrop(e.Item, DragDropEffects.Move | DragDropEffects.Copy);
        }


        private void DragDropHandler(object sender, DragEventArgs e)
        {
            if (lastDragDropTarget != null)
            {
                lastDragDropTarget.BackColor = lastDragDropTargetBackColor;
                lastDragDropTarget = null;
            }

            var sourceNode = GetDragDropSourceNode(e);

            if (sourceNode == null)
            {
                MessageBox.Show(@"Drag & Drop Canceled: Unknown Source");

                return;
            }

            var targetNode = GetDragDropTargetNode(e);

            switch (e.Effect)
            {
                case DragDropEffects.Copy:
                    DoDragDropCopy((dynamic)sourceNode, (dynamic)targetNode);
                    break;
                case DragDropEffects.Move:
                    DoDragDropMove((dynamic)sourceNode, (dynamic)targetNode);
                    break;
            }
        }

        #region >> DoDragDropCopy

    
        private void DoDragDropCopy(JTokenTreeNode sourceNode, JTokenTreeNode targetNode)
        {
            MessageBox.Show(@"Drag & Drop: Unmanaged Copy");
        }


        private void DoDragDropCopy(JPropertyTreeNode sourceNode, JObjectTreeNode targetNode)
        {
            sourceNode.ClipboardCopy();
            targetNode.ClipboardPasteInto();
        }


        private void DoDragDropCopy(JValueTreeNode sourceNode, JArrayTreeNode targetNode)
        {
            sourceNode.ClipboardCopy();
            targetNode.ClipboardPasteInto();
        }

        private void DoDragDropCopy(JObjectTreeNode sourceNode, JArrayTreeNode targetNode)
        {
            sourceNode.ClipboardCopy();
            targetNode.ClipboardPasteInto();
        }


        private void DoDragDropCopy(JArrayTreeNode sourceNode, JArrayTreeNode targetNode)
        {
            sourceNode.ClipboardCopy();
            targetNode.ClipboardPasteInto();
        }

        #endregion

        #region >> DoDragDropMove

        private void DoDragDropMove(JTokenTreeNode sourceNode, JTokenTreeNode targetNode)
        {
            // TODO: Move sourceNode to target
            MessageBox.Show(@"Drag & Drop: Unmanaged Move");
        }

        private void DoDragDropMove(JPropertyTreeNode sourceNode, JObjectTreeNode targetNode)
        {
            sourceNode.ClipboardCut();
            targetNode.ClipboardPasteInto();
        }


        private void DoDragDropMove(JObjectTreeNode sourceNode, JArrayTreeNode targetNode)
        {
            sourceNode.ClipboardCut();
            targetNode.ClipboardPasteInto();
        }

        #endregion

        private void DragEnterHandler(object sender, DragEventArgs e)
        {
        }

        private void DragOverHandler(object sender, DragEventArgs e)
        {
            var targetNode = GetDragDropTargetNode(e);

            if (targetNode == null)
            {
                e.Effect = DragDropEffects.None;

                if (lastDragDropTarget != null)
                {
                    lastDragDropTarget.BackColor = lastDragDropTargetBackColor;
                }

                lastDragDropTarget = null;

                return;
            }

            var keyState = (KeyStates)e.KeyState;
            if (keyState.HasFlag(KeyStates.Control | KeyStates.Shift))
            {
                e.Effect = DragDropEffects.None;
            }
            else if (keyState.HasFlag(KeyStates.Control))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if (keyState.HasFlag(KeyStates.Shift))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.Move;
            }

            var sourceNode = GetDragDropSourceNode(e);

            if (targetNode == lastDragDropTarget)
            {
                if (!targetNode.IsExpanded && DateTime.Now - lastDragOverDateTime >= dragDropExpandDelay)
                {
                    targetNode.Expand();
                }

                if (IsDragDropValid(sourceNode, targetNode, e.Effect))
                {
                    lastDragDropTargetBackColor = targetNode.BackColor;
                    targetNode.BackColor = Color.BlueViolet;
                }
                else
                {
                    targetNode.BackColor = lastDragDropTargetBackColor;
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                lastDragDropTarget = targetNode;
                lastDragOverDateTime = DateTime.Now;

                if (IsDragDropValid(sourceNode, targetNode, e.Effect))
                {
                    lastDragDropTargetBackColor = targetNode.BackColor;
                    targetNode.BackColor = Color.BlueViolet;
                }
                else
                {
                    targetNode.BackColor = lastDragDropTargetBackColor;
                    e.Effect = DragDropEffects.None;
                }
            }

            if (lastDragDropTarget != null)
            {
                lastDragDropTarget.BackColor = lastDragDropTargetBackColor;
            }
        }

        private static JTokenTreeNode GetDragDropSourceNode(DragEventArgs e)
        {
            return e.Data.GetData(e.Data.GetFormats().FirstOrDefault(), true) as JTokenTreeNode;
        }

        private JTokenTreeNode GetDragDropTargetNode(DragEventArgs e)
        {
            var targetPoint = PointToClient(new Point(e.X, e.Y));
            var targetNode = GetNodeAt(targetPoint) as JTokenTreeNode;

            return targetNode;
        }

        private bool IsDragDropValid(JTokenTreeNode sourceNode, JTokenTreeNode targetNode, DragDropEffects effect)
        {
            if (sourceNode == null || targetNode == null)
            {
                return false;
            }

            if (sourceNode.JTokenTag is JProperty)
            {
                return targetNode.JTokenTag is JObject;
            }

            if (sourceNode.JTokenTag is JObject)
            {
                switch (effect)
                {
                    case DragDropEffects.Copy:
                        return targetNode.JTokenTag is JArray;
                    case DragDropEffects.Move:
                        return !(targetNode.JTokenTag.Parent is JProperty)
                               && targetNode.JTokenTag is JArray;
                }
            }

            if (sourceNode.JTokenTag is JArray)
            {
                switch (effect)
                {
                    case DragDropEffects.Copy:
                        return targetNode.JTokenTag is JArray;
                    case DragDropEffects.Move:
                        return !(targetNode.JTokenTag.Parent is JProperty)
                               && targetNode.JTokenTag is JArray;
                }
            }

            if (sourceNode.JTokenTag is JValue)
            {
                switch (effect)
                {
                    case DragDropEffects.Copy:
                        return targetNode.JTokenTag is JArray;
                    case DragDropEffects.Move:
                        return !(targetNode.JTokenTag.Parent is JProperty)
                               && targetNode.JTokenTag is JArray;
                }
            }

            return false;
        }
    }
}
