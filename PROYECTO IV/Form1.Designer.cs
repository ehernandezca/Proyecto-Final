namespace PROYECTO_IV
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btncann = new System.Windows.Forms.Button();
            this.btncambiar = new System.Windows.Forms.Button();
            this.txtcambiarnombre = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acomodarDatosPorCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductorDeMusicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btncann);
            this.splitContainer1.Panel2.Controls.Add(this.btncambiar);
            this.splitContainer1.Panel2.Controls.Add(this.txtcambiarnombre);
            this.splitContainer1.Panel2.Controls.Add(this.btncancelar);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(938, 429);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(224, 429);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "carpeta.jpg");
            this.imageList1.Images.SetKeyName(1, "document.png");
            this.imageList1.Images.SetKeyName(2, "IMA.jpg");
            this.imageList1.Images.SetKeyName(3, "descargas.jpg");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "musica.jpg");
            this.imageList1.Images.SetKeyName(6, "video.png");
            this.imageList1.Images.SetKeyName(7, "word.jpg");
            this.imageList1.Images.SetKeyName(8, "video.png");
            this.imageList1.Images.SetKeyName(9, "iso.jpg");
            this.imageList1.Images.SetKeyName(10, "pdf.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "NOMBRE";
            // 
            // btncann
            // 
            this.btncann.Location = new System.Drawing.Point(386, 240);
            this.btncann.Name = "btncann";
            this.btncann.Size = new System.Drawing.Size(72, 23);
            this.btncann.TabIndex = 14;
            this.btncann.Text = "CANCELAR";
            this.btncann.UseVisualStyleBackColor = true;
            this.btncann.Click += new System.EventHandler(this.Btncann_Click);
            // 
            // btncambiar
            // 
            this.btncambiar.Location = new System.Drawing.Point(302, 240);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(67, 23);
            this.btncambiar.TabIndex = 13;
            this.btncambiar.Text = "CAMBIAR";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Click += new System.EventHandler(this.Btncambiar_Click);
            // 
            // txtcambiarnombre
            // 
            this.txtcambiarnombre.Location = new System.Drawing.Point(302, 214);
            this.txtcambiarnombre.Name = "txtcambiarnombre";
            this.txtcambiarnombre.Size = new System.Drawing.Size(156, 20);
            this.txtcambiarnombre.TabIndex = 12;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(386, 240);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(72, 23);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "NOMBRE DE LA CARPETA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "CREAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(302, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(710, 429);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.ListView1_ItemMouseHover);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NOMBRE";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TIPO";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FECHA DE MODIFICACION";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCarpetaToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.crearToolStripMenuItem,
            this.tamañoToolStripMenuItem,
            this.acomodarDatosPorCarpetaToolStripMenuItem,
            this.cambiarNombreToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 136);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // crearCarpetaToolStripMenuItem
            // 
            this.crearCarpetaToolStripMenuItem.Name = "crearCarpetaToolStripMenuItem";
            this.crearCarpetaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.crearCarpetaToolStripMenuItem.Text = "Copiar";
            this.crearCarpetaToolStripMenuItem.Click += new System.EventHandler(this.CrearCarpetaToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.EliminarToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blocDeNotasToolStripMenuItem,
            this.carpetaToolStripMenuItem});
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // blocDeNotasToolStripMenuItem
            // 
            this.blocDeNotasToolStripMenuItem.Name = "blocDeNotasToolStripMenuItem";
            this.blocDeNotasToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.blocDeNotasToolStripMenuItem.Text = "Bloc de notas";
            this.blocDeNotasToolStripMenuItem.Click += new System.EventHandler(this.BlocDeNotasToolStripMenuItem_Click);
            // 
            // carpetaToolStripMenuItem
            // 
            this.carpetaToolStripMenuItem.Name = "carpetaToolStripMenuItem";
            this.carpetaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.carpetaToolStripMenuItem.Text = "Carpeta";
            this.carpetaToolStripMenuItem.Click += new System.EventHandler(this.CarpetaToolStripMenuItem_Click_1);
            // 
            // tamañoToolStripMenuItem
            // 
            this.tamañoToolStripMenuItem.Name = "tamañoToolStripMenuItem";
            this.tamañoToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.tamañoToolStripMenuItem.Text = "Tamaño";
            this.tamañoToolStripMenuItem.Click += new System.EventHandler(this.TamañoToolStripMenuItem_Click);
            // 
            // acomodarDatosPorCarpetaToolStripMenuItem
            // 
            this.acomodarDatosPorCarpetaToolStripMenuItem.Name = "acomodarDatosPorCarpetaToolStripMenuItem";
            this.acomodarDatosPorCarpetaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.acomodarDatosPorCarpetaToolStripMenuItem.Text = "Acomodar archivos por carpeta";
            this.acomodarDatosPorCarpetaToolStripMenuItem.Click += new System.EventHandler(this.AcomodarDatosPorCarpetaToolStripMenuItem_Click);
            // 
            // cambiarNombreToolStripMenuItem
            // 
            this.cambiarNombreToolStripMenuItem.Name = "cambiarNombreToolStripMenuItem";
            this.cambiarNombreToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.cambiarNombreToolStripMenuItem.Text = "Cambiar nombre";
            this.cambiarNombreToolStripMenuItem.Click += new System.EventHandler(this.CambiarNombreToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(822, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(762, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "BUSCAR:";
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(228, 1);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(528, 20);
            this.txtruta.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reproductorDeMusicaToolStripMenuItem,
            this.wordToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.videoToolStripMenuItem.Text = "Archivo";
            // 
            // reproductorDeMusicaToolStripMenuItem
            // 
            this.reproductorDeMusicaToolStripMenuItem.Name = "reproductorDeMusicaToolStripMenuItem";
            this.reproductorDeMusicaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.reproductorDeMusicaToolStripMenuItem.Text = "Reproductor de musica";
            this.reproductorDeMusicaToolStripMenuItem.Click += new System.EventHandler(this.ReproductorDeMusicaToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.WordToolStripMenuItem_Click_1);
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(194, 1);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(30, 20);
            this.btnregresar.TabIndex = 9;
            this.btnregresar.Text = "<-";
            this.btnregresar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 453);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EXPLORADOR DE ARCHIVOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearCarpetaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocDeNotasToolStripMenuItem;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.ToolStripMenuItem carpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamañoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acomodarDatosPorCarpetaToolStripMenuItem;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarNombreToolStripMenuItem;
        private System.Windows.Forms.TextBox txtcambiarnombre;
        private System.Windows.Forms.Button btncambiar;
        private System.Windows.Forms.Button btncann;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem reproductorDeMusicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
    }
}