namespace Explorador_de_archivos_proyecto
{
    partial class frmSaturacion
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
            this.saturationTrackBar = new System.Windows.Forms.TrackBar();
            this.saturationBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterPreview1 = new Explorador_de_archivos_proyecto.FilterPreview();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(139, 165);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(58, 165);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 25;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // saturationTrackBar
            // 
            this.saturationTrackBar.Location = new System.Drawing.Point(12, 55);
            this.saturationTrackBar.Maximum = 1000;
            this.saturationTrackBar.Minimum = -1000;
            this.saturationTrackBar.Name = "saturationTrackBar";
            this.saturationTrackBar.Size = new System.Drawing.Size(250, 45);
            this.saturationTrackBar.TabIndex = 24;
            this.saturationTrackBar.TickFrequency = 50;
            this.saturationTrackBar.ValueChanged += new System.EventHandler(this.saturationTrackBar_ValueChanged);
            // 
            // saturationBox
            // 
            this.saturationBox.Location = new System.Drawing.Point(127, 20);
            this.saturationBox.Name = "saturationBox";
            this.saturationBox.Size = new System.Drawing.Size(50, 20);
            this.saturationBox.TabIndex = 23;
            this.saturationBox.TextChanged += new System.EventHandler(this.saturationBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterPreview1);
            this.groupBox1.Location = new System.Drawing.Point(271, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 175);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Previsualizacion";
            // 
            // filterPreview1
            // 
            this.filterPreview1.Image = null;
            this.filterPreview1.Location = new System.Drawing.Point(6, 19);
            this.filterPreview1.Name = "filterPreview1";
            this.filterPreview1.Size = new System.Drawing.Size(158, 156);
            this.filterPreview1.TabIndex = 0;
            this.filterPreview1.Text = "filterPreview1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ajustar saturacion por:";
            // 
            // frmSaturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 207);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.saturationTrackBar);
            this.Controls.Add(this.saturationBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSaturacion";
            this.Text = "Saturacion";
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TrackBar saturationTrackBar;
        private System.Windows.Forms.TextBox saturationBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private FilterPreview filterPreview1;
        private System.Windows.Forms.Label label1;
    }
}