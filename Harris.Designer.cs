namespace OpenCVTestCSharp
{
    partial class Harris
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
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnHarrisLoad = new System.Windows.Forms.Button();
            this.btnHarrisApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // picOriginal
            // 
            this.picOriginal.Location = new System.Drawing.Point(37, 46);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(371, 503);
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(445, 46);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(416, 503);
            this.picResult.TabIndex = 1;
            this.picResult.TabStop = false;
            // 
            // btnHarrisLoad
            // 
            this.btnHarrisLoad.Location = new System.Drawing.Point(286, 577);
            this.btnHarrisLoad.Name = "btnHarrisLoad";
            this.btnHarrisLoad.Size = new System.Drawing.Size(122, 34);
            this.btnHarrisLoad.TabIndex = 2;
            this.btnHarrisLoad.Text = "Load Image";
            this.btnHarrisLoad.UseVisualStyleBackColor = true;
            this.btnHarrisLoad.Click += new System.EventHandler(this.btnHarrisLoad_Click);
            // 
            // btnHarrisApply
            // 
            this.btnHarrisApply.Location = new System.Drawing.Point(428, 577);
            this.btnHarrisApply.Name = "btnHarrisApply";
            this.btnHarrisApply.Size = new System.Drawing.Size(121, 34);
            this.btnHarrisApply.TabIndex = 3;
            this.btnHarrisApply.Text = "Apply Harris";
            this.btnHarrisApply.UseVisualStyleBackColor = true;
            this.btnHarrisApply.Click += new System.EventHandler(this.btnHarrisApply_Click);
            // 
            // Harris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 653);
            this.Controls.Add(this.btnHarrisApply);
            this.Controls.Add(this.btnHarrisLoad);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picOriginal);
            this.Name = "Harris";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnHarrisLoad;
        private System.Windows.Forms.Button btnHarrisApply;
    }
}

