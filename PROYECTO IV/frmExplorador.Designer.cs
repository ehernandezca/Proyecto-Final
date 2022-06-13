namespace Explorador_de_archivos_proyecto
{
    partial class frmExplorador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtRutaActual = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductorDeAudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.editorJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorXlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visorPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visorPDFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMenuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.cmMenuContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel2.Controls.Add(this.txtRutaActual);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(181, 450);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // txtRutaActual
            // 
            this.txtRutaActual.Location = new System.Drawing.Point(72, 2);
            this.txtRutaActual.Name = "txtRutaActual";
            this.txtRutaActual.Size = new System.Drawing.Size(542, 20);
            this.txtRutaActual.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(615, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            this.listView1.MouseHover += new System.EventHandler(this.listView1_MouseHover);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 247;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ultima modificacion";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 217;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.reproductorDeAudioToolStripMenuItem,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem5.Text = "Reproductor de video";
            // 
            // reproductorDeAudioToolStripMenuItem
            // 
            this.reproductorDeAudioToolStripMenuItem.Name = "reproductorDeAudioToolStripMenuItem";
            this.reproductorDeAudioToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reproductorDeAudioToolStripMenuItem.Text = "Reproductor de audio";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem6.Text = "Editor de imagen";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorJsonToolStripMenuItem,
            this.editorDocToolStripMenuItem,
            this.editorXlsToolStripMenuItem,
            this.editorXmlToolStripMenuItem,
            this.visorPDFToolStripMenuItem,
            this.visorPDFToolStripMenuItem1});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem7.Text = "Ofimatica";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // editorJsonToolStripMenuItem
            // 
            this.editorJsonToolStripMenuItem.Name = "editorJsonToolStripMenuItem";
            this.editorJsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorJsonToolStripMenuItem.Text = "Editor Json";
            this.editorJsonToolStripMenuItem.Click += new System.EventHandler(this.editorJsonToolStripMenuItem_Click);
            // 
            // editorDocToolStripMenuItem
            // 
            this.editorDocToolStripMenuItem.Name = "editorDocToolStripMenuItem";
            this.editorDocToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorDocToolStripMenuItem.Text = "Editor Doc";
            // 
            // editorXlsToolStripMenuItem
            // 
            this.editorXlsToolStripMenuItem.Name = "editorXlsToolStripMenuItem";
            this.editorXlsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorXlsToolStripMenuItem.Text = "Editor Xls";
            // 
            // editorXmlToolStripMenuItem
            // 
            this.editorXmlToolStripMenuItem.Name = "editorXmlToolStripMenuItem";
            this.editorXmlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorXmlToolStripMenuItem.Text = "Editor Xml";
            // 
            // visorPDFToolStripMenuItem
            // 
            this.visorPDFToolStripMenuItem.Name = "visorPDFToolStripMenuItem";
            this.visorPDFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visorPDFToolStripMenuItem.Text = "Editor Txt";
            // 
            // visorPDFToolStripMenuItem1
            // 
            this.visorPDFToolStripMenuItem1.Name = "visorPDFToolStripMenuItem1";
            this.visorPDFToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.visorPDFToolStripMenuItem1.Text = "Visor PDF";
            // 
            // cmMenuContextual
            // 
            this.cmMenuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.pegarToolStripMenuItem,
            this.nuevaCarpetaToolStripMenuItem});
            this.cmMenuContextual.Name = "Abrir";
            this.cmMenuContextual.Size = new System.Drawing.Size(153, 114);
            this.cmMenuContextual.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Abrir";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Copiar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "Eliminar";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // nuevaCarpetaToolStripMenuItem
            // 
            this.nuevaCarpetaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.nuevaCarpetaToolStripMenuItem.Name = "nuevaCarpetaToolStripMenuItem";
            this.nuevaCarpetaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaCarpetaToolStripMenuItem.Text = "Nueva Carpeta";
            this.nuevaCarpetaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCarpetaToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.ToolTipText = "Escriba el nombre de la nueva carpeta";
            // 
            // frmExplorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmExplorador";
            this.RightToLeftLayout = true;
            this.Text = "Explorador de archivos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmMenuContextual.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip cmMenuContextual;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem reproductorDeAudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorXlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visorPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visorPDFToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtRutaActual;
        private System.Windows.Forms.ToolStripMenuItem nuevaCarpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

