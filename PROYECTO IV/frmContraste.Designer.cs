namespace Explorador_de_archivos_proyecto
{
    partial class frmContraste
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.contrastBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterPreview1 = new Explorador_de_archivos_proyecto.FilterPreview();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(148, 162);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(67, 162);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 19;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(21, 52);
            this.contrastTrackBar.Maximum = 5000;
            this.contrastTrackBar.Minimum = 1;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(250, 45);
            this.contrastTrackBar.TabIndex = 18;
            this.contrastTrackBar.TickFrequency = 200;
            this.contrastTrackBar.Value = 1;
            this.contrastTrackBar.ValueChanged += new System.EventHandler(this.contrastTrackBar_ValueChanged);
            // 
            // contrastBox
            // 
            this.contrastBox.Location = new System.Drawing.Point(126, 17);
            this.contrastBox.Name = "contrastBox";
            this.contrastBox.Size = new System.Drawing.Size(50, 20);
            this.contrastBox.TabIndex = 17;
            this.contrastBox.TextChanged += new System.EventHandler(this.contrastBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Factor de contraste";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterPreview1);
            this.groupBox1.Location = new System.Drawing.Point(280, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 175);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Previsualizcion";
            // 
            // filterPreview1
            // 
            this.filterPreview1.Image = null;
            this.filterPreview1.Location = new System.Drawing.Point(6, 19);
            this.filterPreview1.Name = "filterPreview1";
            this.filterPreview1.Size = new System.Drawing.Size(158, 150);
            this.filterPreview1.TabIndex = 0;
            this.filterPreview1.Text = "filterPreview1";
            // 
            // frmContraste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 205);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.contrastTrackBar);
            this.Controls.Add(this.contrastBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmContraste";
            this.Text = "Contraste";
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.TextBox contrastBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FilterPreview filterPreview1;
    }
}