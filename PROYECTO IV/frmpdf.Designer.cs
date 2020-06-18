namespace PROYECTO_IV
{
    partial class frmpdf
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnHandTool = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.combZoom = new System.Windows.Forms.ComboBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.comBox = new System.Windows.Forms.ComboBox();
            this.btnabrir = new System.Windows.Forms.Button();
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(169, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(57, 23);
            this.btnPrint.TabIndex = 25;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnHandTool
            // 
            this.btnHandTool.Enabled = false;
            this.btnHandTool.Location = new System.Drawing.Point(643, 12);
            this.btnHandTool.Name = "btnHandTool";
            this.btnHandTool.Size = new System.Drawing.Size(69, 23);
            this.btnHandTool.TabIndex = 20;
            this.btnHandTool.Text = "Manita";
            this.btnHandTool.UseVisualStyleBackColor = true;
            this.btnHandTool.Click += new System.EventHandler(this.BtnHandTool_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(643, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Enabled = false;
            this.btnZoomIn.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.Location = new System.Drawing.Point(519, 12);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(29, 23);
            this.btnZoomIn.TabIndex = 23;
            this.btnZoomIn.Text = "-";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.BtnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Enabled = false;
            this.btnZoomOut.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(488, 12);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(29, 23);
            this.btnZoomOut.TabIndex = 24;
            this.btnZoomOut.Text = "+";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.BtnZoomOut_Click);
            // 
            // combZoom
            // 
            this.combZoom.Enabled = false;
            this.combZoom.FormattingEnabled = true;
            this.combZoom.Location = new System.Drawing.Point(554, 11);
            this.combZoom.Name = "combZoom";
            this.combZoom.Size = new System.Drawing.Size(73, 21);
            this.combZoom.TabIndex = 22;
            this.combZoom.SelectedIndexChanged += new System.EventHandler(this.CombZoom_SelectedIndexChanged);
            // 
            // btnLast
            // 
            this.btnLast.Enabled = false;
            this.btnLast.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(425, 12);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(43, 23);
            this.btnLast.TabIndex = 19;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(376, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(43, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(281, 11);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(43, 23);
            this.btnPrevious.TabIndex = 17;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Enabled = false;
            this.btnFirst.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(232, 11);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(43, 23);
            this.btnFirst.TabIndex = 16;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // comBox
            // 
            this.comBox.Enabled = false;
            this.comBox.FormattingEnabled = true;
            this.comBox.Location = new System.Drawing.Point(330, 12);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(40, 21);
            this.comBox.TabIndex = 15;
            this.comBox.SelectedIndexChanged += new System.EventHandler(this.ComBox_SelectedIndexChanged);
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(117, 12);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(46, 23);
            this.btnabrir.TabIndex = 14;
            this.btnabrir.Text = "OPEN";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.Btnabrir_Click);
            // 
            // pdfDocumentViewer1
            // 
            this.pdfDocumentViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pdfDocumentViewer1.Location = new System.Drawing.Point(27, 41);
            this.pdfDocumentViewer1.MultiPagesThreshold = 60;
            this.pdfDocumentViewer1.Name = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Size = new System.Drawing.Size(876, 411);
            this.pdfDocumentViewer1.TabIndex = 26;
            this.pdfDocumentViewer1.Text = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Threshold = 60;
            this.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;

            // 
            // apppdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 482);
            this.Controls.Add(this.pdfDocumentViewer1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnHandTool);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.combZoom);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.comBox);
            this.Controls.Add(this.btnabrir);
            this.Name = "apppdf";
            this.Text = "apppdf";
            this.Load += new System.EventHandler(this.Apppdf_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnHandTool;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.ComboBox combZoom;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.ComboBox comBox;
        private System.Windows.Forms.Button btnabrir;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
    }
}