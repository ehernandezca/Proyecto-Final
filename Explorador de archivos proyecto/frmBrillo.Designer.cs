namespace Explorador_de_archivos_proyecto
{
    partial class frmBrillo
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
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.brightnessBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterPreview1 = new Explorador_de_archivos_proyecto.FilterPreview();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(139, 163);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(58, 163);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(12, 53);
            this.brightnessTrackBar.Maximum = 1000;
            this.brightnessTrackBar.Minimum = -1000;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(250, 45);
            this.brightnessTrackBar.TabIndex = 12;
            this.brightnessTrackBar.TickFrequency = 50;
            this.brightnessTrackBar.ValueChanged += new System.EventHandler(this.brightnessTrackBar_ValueChanged);
            // 
            // brightnessBox
            // 
            this.brightnessBox.Location = new System.Drawing.Point(122, 18);
            this.brightnessBox.Name = "brightnessBox";
            this.brightnessBox.Size = new System.Drawing.Size(50, 20);
            this.brightnessBox.TabIndex = 11;
            this.brightnessBox.TextChanged += new System.EventHandler(this.brightnessBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ajustar brillo por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterPreview1);
            this.groupBox1.Location = new System.Drawing.Point(271, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 175);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vista anicipada";
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
            // frmBrillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 209);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.brightnessBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBrillo";
            this.Text = "Brillo";
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.TextBox brightnessBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FilterPreview filterPreview;
        private FilterPreview filterPreview1;
    }
}