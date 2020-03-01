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
            try 
            {
                Image<Gray, float> response = new Image<Gray, float>(img.Size); //we store in the response image
                CvInvoke.CornerHarris(img, response, 2, 3, 0.04); //calling Harris Corner Detector
                double max = 0;
                double min = 0;
                Point maxLoc = new Point(0, 0);
                Point minLoc = new Point(0, 0);
                CvInvoke.MinMaxLoc(response, ref min, ref max, ref minLoc, ref maxLoc); //Locating the maximum response
                Bitmap result = (Bitmap)picOriginal.Image.Clone();
                double tresh = 0.01 * max;
                //For the i, j locations where the response[i,j] > tresh, we will set the pixel(i,j) to Red.
                for (int i = 0; i < result.Width; i++)
                {
                    for (int j = 0; j < result.Height; j++)
                    {
                        double r = response.Data[i, j, 0];
                        if (r > tresh)
                        {
                            //Setting to Red
                            result.SetPixel(j, i, Color.FromArgb(255, 0, 0));
                        }
                    }
                }
                picResult.Image = result;
            }catch (Exception ex)
            {
                MessageBox.Show("Please load image first.");
            }
        }
    }
}
