﻿using ZTn.Json.JsonTreeView.Controls;

namespace ZTn.Json.Editor.Forms
{
    partial class JsonEditorMainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.jsonTreeViewSplitContainer = new System.Windows.Forms.SplitContainer();
            this.jTokenTree = new ZTn.Json.JsonTreeView.Controls.JTokenTreeUserControl();
            this.jsonTypeComboBox = new System.Windows.Forms.ComboBox();
            this.jsonValueTextBox = new System.Windows.Forms.TextBox();
            this.jsonValueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newtonsoftJsonTypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.formMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJsonObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJsonArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.jsonTreeViewSplitContainer)).BeginInit();
            this.jsonTreeViewSplitContainer.Panel1.SuspendLayout();
            this.jsonTreeViewSplitContainer.Panel2.SuspendLayout();
            this.jsonTreeViewSplitContainer.SuspendLayout();
            this.formMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // jsonTreeViewSplitContainer
            // 
            this.jsonTreeViewSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonTreeViewSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.jsonTreeViewSplitContainer.Name = "jsonTreeViewSplitContainer";
            // 
            // jsonTreeViewSplitContainer.Panel1
            // 
            this.jsonTreeViewSplitContainer.Panel1.Controls.Add(this.jTokenTree);
            this.jsonTreeViewSplitContainer.Panel1MinSize = 200;
            // 
            // jsonTreeViewSplitContainer.Panel2
            // 
            this.jsonTreeViewSplitContainer.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.jsonTypeComboBox);
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.jsonValueTextBox);
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.jsonValueLabel);
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.label2);
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.newtonsoftJsonTypeTextBox);
            this.jsonTreeViewSplitContainer.Panel2.Controls.Add(this.label1);
            this.jsonTreeViewSplitContainer.Panel2MinSize = 320;
            this.jsonTreeViewSplitContainer.Size = new System.Drawing.Size(1008, 552);
            this.jsonTreeViewSplitContainer.SplitterDistance = 672;
            this.jsonTreeViewSplitContainer.TabIndex = 8;
            // 
            // jTokenTree
            // 
            this.jTokenTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jTokenTree.CollapsedFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTokenTree.ExpandedFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.jTokenTree.Location = new System.Drawing.Point(3, 3);
            this.jTokenTree.Margin = new System.Windows.Forms.Padding(6);
            this.jTokenTree.Name = "jTokenTree";
            this.jTokenTree.Size = new System.Drawing.Size(666, 546);
            this.jTokenTree.TabIndex = 2;
            this.jTokenTree.AfterSelect += new System.EventHandler<ZTn.Json.JsonTreeView.AfterSelectEventArgs>(this.jTokenTree_AfterSelect);
            // 
            // jsonTypeComboBox
            // 
            this.jsonTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jsonTypeComboBox.Enabled = false;
            this.jsonTypeComboBox.FormattingEnabled = true;
            this.jsonTypeComboBox.Location = new System.Drawing.Point(3, 59);
            this.jsonTypeComboBox.Name = "jsonTypeComboBox";
            this.jsonTypeComboBox.Size = new System.Drawing.Size(154, 21);
            this.jsonTypeComboBox.TabIndex = 7;
            // 
            // jsonValueTextBox
            // 
            this.jsonValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonValueTextBox.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.jsonValueTextBox.Location = new System.Drawing.Point(3, 97);
            this.jsonValueTextBox.Multiline = true;
            this.jsonValueTextBox.Name = "jsonValueTextBox";
            this.jsonValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonValueTextBox.Size = new System.Drawing.Size(323, 452);
            this.jsonValueTextBox.TabIndex = 6;
            this.jsonValueTextBox.Enter += new System.EventHandler(this.jsonValueTextBox_Enter);
            this.jsonValueTextBox.Leave += new System.EventHandler(this.jsonValueTextBox_Leave);
            // 
            // jsonValueLabel
            // 
            this.jsonValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.jsonValueLabel.AutoSize = true;
            this.jsonValueLabel.Location = new System.Drawing.Point(3, 81);
            this.jsonValueLabel.Name = "jsonValueLabel";
            this.jsonValueLabel.Size = new System.Drawing.Size(56, 13);
            this.jsonValueLabel.TabIndex = 5;
            this.jsonValueLabel.Text = "Valor Json";
            this.jsonValueLabel.TextChanged += new System.EventHandler(this.jsonValueTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Json newtonsoft";
            // 
            // newtonsoftJsonTypeTextBox
            // 
            this.newtonsoftJsonTypeTextBox.Location = new System.Drawing.Point(3, 19);
            this.newtonsoftJsonTypeTextBox.Name = "newtonsoftJsonTypeTextBox";
            this.newtonsoftJsonTypeTextBox.ReadOnly = true;
            this.newtonsoftJsonTypeTextBox.Size = new System.Drawing.Size(154, 20);
            this.newtonsoftJsonTypeTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Json";
            // 
            // formMenuStrip
            // 
            this.formMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.formMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.formMenuStrip.Name = "formMenuStrip";
            this.formMenuStrip.Size = new System.Drawing.Size(1008, 24);
            this.formMenuStrip.TabIndex = 0;
            this.formMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "Archivo";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newJsonObjectToolStripMenuItem,
            this.newJsonArrayToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShowShortcutKeys = false;
            this.newToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.newToolStripMenuItem.Text = "Nuevo";
            // 
            // newJsonObjectToolStripMenuItem
            // 
            this.newJsonObjectToolStripMenuItem.Name = "newJsonObjectToolStripMenuItem";
            this.newJsonObjectToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newJsonObjectToolStripMenuItem.Text = "New Json &Object";
            this.newJsonObjectToolStripMenuItem.Click += new System.EventHandler(this.newJsonObjectToolStripMenuItem_Click);
            // 
            // newJsonArrayToolStripMenuItem
            // 
            this.newJsonArrayToolStripMenuItem.Name = "newJsonArrayToolStripMenuItem";
            this.newJsonArrayToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newJsonArrayToolStripMenuItem.Text = "New Json &Array";
            this.newJsonArrayToolStripMenuItem.Click += new System.EventHandler(this.newJsonArrayToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.openToolStripMenuItem.Text = "Abrir";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveToolStripMenuItem.Text = "Guardar";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveAsToolStripMenuItem.Text = "Guardar Como";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // JsonEditorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.jsonTreeViewSplitContainer);
            this.Controls.Add(this.formMenuStrip);
            this.MainMenuStrip = this.formMenuStrip;
            this.Name = "JsonEditorMainForm";
            this.Text = "Editor Json";
            this.jsonTreeViewSplitContainer.Panel1.ResumeLayout(false);
            this.jsonTreeViewSplitContainer.Panel2.ResumeLayout(false);
            this.jsonTreeViewSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jsonTreeViewSplitContainer)).EndInit();
            this.jsonTreeViewSplitContainer.ResumeLayout(false);
            this.formMenuStrip.ResumeLayout(false);
            this.formMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip formMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newtonsoftJsonTypeTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label jsonValueLabel;
        private System.Windows.Forms.SplitContainer jsonTreeViewSplitContainer;
        private System.Windows.Forms.TextBox jsonValueTextBox;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newJsonObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newJsonArrayToolStripMenuItem;
        private System.Windows.Forms.ComboBox jsonTypeComboBox;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private JTokenTreeUserControl jTokenTree;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

