using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCVTestCSharp
{
    public partial class Harris : Form
    {
        private Image<Gray, Byte> img = null;

        public ThresholdType Otsu { get; private set; }
        public BorderType BORDER_CONSTANT { get; private set; }

        public Harris()
        {
            InitializeComponent();
        }

        private void btnHarrisLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpeg files (*.jpg)|*.jpg|(*.gif)|gif||";
            if (DialogResult.OK == dialog.ShowDialog())
            {
                this.img = new Image<Gray, Byte>(dialog.FileName); //Corner detection requires grayscale
                this.picOriginal.Image = new Bitmap(dialog.FileName);
            }
        }

        private void btnHarrisApply_Click(object sender, EventArgs e)
        {
            Image<Gray, float> response = new Image<Gray, float>(img.Size); //we store in the response image
            CvInvoke.CornerHarris(img, response, 2, 3, 0.04); //calling Harris Corner Detector
            Image<Gray, Byte> output = new Image<Gray, Byte>(img.Size);
            Image<Gray, float> dst = new Image<Gray, float>(img.Size);
            CvInvoke.Threshold(response, output, 0.01, 255.0, Otsu);
            picResult.Image = response.ToBitmap();
            
        }
    }
}
