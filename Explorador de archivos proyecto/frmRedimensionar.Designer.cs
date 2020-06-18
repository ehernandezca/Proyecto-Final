namespace Explorador_de_archivos_proyecto
{
    partial class frmRedimensionar
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
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ratioCheck = new System.Windows.Forms.CheckBox();
            this.sizeButton = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.factorBox = new System.Windows.Forms.TextBox();
            this.factorButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.methodCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.resizeTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // heightBox
            // 
            this.heightBox.Enabled = false;
            this.heightBox.Location = new System.Drawing.Point(122, 147);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 28;
            this.heightBox.TextChanged += new System.EventHandler(this.heightBox_TextChanged);
            // 
            // widthBox
            // 
            this.widthBox.Enabled = false;
            this.widthBox.Location = new System.Drawing.Point(122, 117);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 27;
            this.widthBox.TextChanged += new System.EventHandler(this.widthBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Altura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ancho:";
            // 
            // ratioCheck
            // 
            this.ratioCheck.AutoSize = true;
            this.ratioCheck.Checked = true;
            this.ratioCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ratioCheck.Enabled = false;
            this.ratioCheck.Location = new System.Drawing.Point(60, 181);
            this.ratioCheck.Name = "ratioCheck";
            this.ratioCheck.Size = new System.Drawing.Size(167, 17);
            this.ratioCheck.TabIndex = 24;
            this.ratioCheck.Text = "Mantener relacion de aspecto";
            this.ratioCheck.UseVisualStyleBackColor = true;
            // 
            // sizeButton
            // 
            this.sizeButton.AutoSize = true;
            this.sizeButton.Location = new System.Drawing.Point(21, 89);
            this.sizeButton.Name = "sizeButton";
            this.sizeButton.Size = new System.Drawing.Size(221, 17);
            this.sizeButton.TabIndex = 23;
            this.sizeButton.TabStop = true;
            this.sizeButton.Text = "Redimensionar a dimensiones especificas";
            this.sizeButton.UseVisualStyleBackColor = true;
            this.sizeButton.CheckedChanged += new System.EventHandler(this.sizeButton_CheckedChanged_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(21, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 2);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // factorBox
            // 
            this.factorBox.Location = new System.Drawing.Point(142, 10);
            this.factorBox.Name = "factorBox";
            this.factorBox.Size = new System.Drawing.Size(100, 20);
            this.factorBox.TabIndex = 21;
            this.factorBox.TextChanged += new System.EventHandler(this.factorBox_TextChanged);
            // 
            // factorButton
            // 
            this.factorButton.AutoSize = true;
            this.factorButton.Checked = true;
            this.factorButton.Location = new System.Drawing.Point(9, 11);
            this.factorButton.Name = "factorButton";
            this.factorButton.Size = new System.Drawing.Size(132, 17);
            this.factorButton.TabIndex = 20;
            this.factorButton.TabStop = true;
            this.factorButton.Text = "Factor de redimension:";
            this.factorButton.UseVisualStyleBackColor = true;
            this.factorButton.CheckedChanged += new System.EventHandler(this.factorButton_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 2);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // methodCombo
            // 
            this.methodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodCombo.FormattingEnabled = true;
            this.methodCombo.Items.AddRange(new object[] {
            "Lo mas cercano",
            "Bilinear",
            "Bicubico"});
            this.methodCombo.Location = new System.Drawing.Point(104, 224);
            this.methodCombo.Name = "methodCombo";
            this.methodCombo.Size = new System.Drawing.Size(121, 21);
            this.methodCombo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Interpolacion:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(126, 264);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(45, 264);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // resizeTrackBar
            // 
            this.resizeTrackBar.Location = new System.Drawing.Point(21, 37);
            this.resizeTrackBar.Maximum = 500;
            this.resizeTrackBar.Minimum = 1;
            this.resizeTrackBar.Name = "resizeTrackBar";
            this.resizeTrackBar.Size = new System.Drawing.Size(204, 45);
            this.resizeTrackBar.TabIndex = 29;
            this.resizeTrackBar.TickFrequency = 25;
            this.resizeTrackBar.Value = 200;
            this.resizeTrackBar.Scroll += new System.EventHandler(this.resizeTrackBar_Scroll);
            this.resizeTrackBar.ValueChanged += new System.EventHandler(this.resizeTrackBar_ValueChanged);
            // 
            // frmRedimensionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 315);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ratioCheck);
            this.Controls.Add(this.sizeButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.factorBox);
            this.Controls.Add(this.factorButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.methodCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.resizeTrackBar);
            this.Name = "frmRedimensionar";
            this.Text = "Redimensionar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ratioCheck;
        private System.Windows.Forms.RadioButton sizeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox factorBox;
        private System.Windows.Forms.RadioButton factorButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox methodCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TrackBar resizeTrackBar;
    }
}