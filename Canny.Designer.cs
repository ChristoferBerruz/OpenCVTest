namespace OpenCVTestCSharp
{
    partial class Canny
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
            this.picResult = new System.Windows.Forms.PictureBox();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.btnCannyLoad = new System.Windows.Forms.Button();
            this.btnCannyApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(400, 71);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(355, 490);
            this.picResult.TabIndex = 0;
            this.picResult.TabStop = false;
            // 
            // picOriginal
            // 
            this.picOriginal.Location = new System.Drawing.Point(31, 71);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(331, 490);
            this.picOriginal.TabIndex = 1;
            this.picOriginal.TabStop = false;
            // 
            // btnCannyLoad
            // 
            this.btnCannyLoad.Location = new System.Drawing.Point(228, 592);
            this.btnCannyLoad.Name = "btnCannyLoad";
            this.btnCannyLoad.Size = new System.Drawing.Size(134, 47);
            this.btnCannyLoad.TabIndex = 2;
            this.btnCannyLoad.Text = "Load Image";
            this.btnCannyLoad.UseVisualStyleBackColor = true;
            this.btnCannyLoad.Click += new System.EventHandler(this.btnCannyLoad_Click);
            // 
            // btnCannyApply
            // 
            this.btnCannyApply.Location = new System.Drawing.Point(400, 593);
            this.btnCannyApply.Name = "btnCannyApply";
            this.btnCannyApply.Size = new System.Drawing.Size(130, 46);
            this.btnCannyApply.TabIndex = 3;
            this.btnCannyApply.Text = "Apply Canny";
            this.btnCannyApply.UseVisualStyleBackColor = true;
            this.btnCannyApply.Click += new System.EventHandler(this.btnCannyApply_Click);
            // 
            // Canny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 681);
            this.Controls.Add(this.btnCannyApply);
            this.Controls.Add(this.btnCannyLoad);
            this.Controls.Add(this.picOriginal);
            this.Controls.Add(this.picResult);
            this.Name = "Canny";
            this.Text = "Canny";
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.Button btnCannyLoad;
        private System.Windows.Forms.Button btnCannyApply;
    }
}