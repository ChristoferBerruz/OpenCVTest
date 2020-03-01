namespace OpenCVTestCSharp
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenCanny = new System.Windows.Forms.Button();
            this.btnOpenHarris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to OpenCV Test";
            // 
            // btnOpenCanny
            // 
            this.btnOpenCanny.Location = new System.Drawing.Point(130, 133);
            this.btnOpenCanny.Name = "btnOpenCanny";
            this.btnOpenCanny.Size = new System.Drawing.Size(110, 57);
            this.btnOpenCanny.TabIndex = 1;
            this.btnOpenCanny.Text = "Canny Edge Detector";
            this.btnOpenCanny.UseVisualStyleBackColor = true;
            this.btnOpenCanny.Click += new System.EventHandler(this.btnOpenCanny_Click);
            // 
            // btnOpenHarris
            // 
            this.btnOpenHarris.Location = new System.Drawing.Point(314, 133);
            this.btnOpenHarris.Name = "btnOpenHarris";
            this.btnOpenHarris.Size = new System.Drawing.Size(109, 58);
            this.btnOpenHarris.TabIndex = 2;
            this.btnOpenHarris.Text = "Harris Corner Detector";
            this.btnOpenHarris.UseVisualStyleBackColor = true;
            this.btnOpenHarris.Click += new System.EventHandler(this.btnOpenHarris_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 320);
            this.Controls.Add(this.btnOpenHarris);
            this.Controls.Add(this.btnOpenCanny);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenCanny;
        private System.Windows.Forms.Button btnOpenHarris;
    }
}