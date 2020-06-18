namespace PROYECTO_IV
{
    partial class frmword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncursiva = new System.Windows.Forms.Button();
            this.btnsubrayado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnnegrita = new System.Windows.Forms.Button();
            this.txtdocumento = new System.Windows.Forms.RichTextBox();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnmas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncursiva
            // 
            this.btncursiva.Location = new System.Drawing.Point(384, 37);
            this.btncursiva.Name = "btncursiva";
            this.btncursiva.Size = new System.Drawing.Size(33, 23);
            this.btncursiva.TabIndex = 20;
            this.btncursiva.Text = "K";
            this.btncursiva.UseVisualStyleBackColor = true;
            this.btncursiva.Click += new System.EventHandler(this.Btncursiva_Click);
            // 
            // btnsubrayado
            // 
            this.btnsubrayado.Location = new System.Drawing.Point(345, 37);
            this.btnsubrayado.Name = "btnsubrayado";
            this.btnsubrayado.Size = new System.Drawing.Size(33, 23);
            this.btnsubrayado.TabIndex = 19;
            this.btnsubrayado.Text = "S";
            this.btnsubrayado.UseVisualStyleBackColor = true;
            this.btnsubrayado.Click += new System.EventHandler(this.Btnsubrayado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "TAMAÑO DE LETRA";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(194, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 17;
            // 
            // btnnegrita
            // 
            this.btnnegrita.Location = new System.Drawing.Point(306, 37);
            this.btnnegrita.Name = "btnnegrita";
            this.btnnegrita.Size = new System.Drawing.Size(33, 23);
            this.btnnegrita.TabIndex = 16;
            this.btnnegrita.Text = "N";
            this.btnnegrita.UseVisualStyleBackColor = true;
            this.btnnegrita.Click += new System.EventHandler(this.Btnnegrita_Click);
            // 
            // txtdocumento
            // 
            this.txtdocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdocumento.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.Location = new System.Drawing.Point(0, 63);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(788, 373);
            this.txtdocumento.TabIndex = 15;
            this.txtdocumento.Text = "";
            // 
            // btnmenos
            // 
            this.btnmenos.Location = new System.Drawing.Point(159, 34);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(29, 23);
            this.btnmenos.TabIndex = 14;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.Btnmenos_Click);
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(237, 34);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(28, 23);
            this.btnmas.TabIndex = 13;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.Btnmas_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem1,
            this.abrToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.guardarToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem1
            // 
            this.guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            this.guardarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem1.Text = "Abrir";
            this.guardarToolStripMenuItem1.Click += new System.EventHandler(this.GuardarToolStripMenuItem1_Click);
            // 
            // abrToolStripMenuItem
            // 
            this.abrToolStripMenuItem.Name = "abrToolStripMenuItem";
            this.abrToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrToolStripMenuItem.Text = "Guardar";
            this.abrToolStripMenuItem.Click += new System.EventHandler(this.AbrToolStripMenuItem_Click);
            // 
            // appword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncursiva);
            this.Controls.Add(this.btnsubrayado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnnegrita);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.menuStrip1);
            this.Name = "appword";
            this.Text = "appword";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncursiva;
        private System.Windows.Forms.Button btnsubrayado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnnegrita;
        private System.Windows.Forms.RichTextBox txtdocumento;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrToolStripMenuItem;
    }
}