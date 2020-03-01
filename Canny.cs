using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace OpenCVTestCSharp
{
    public partial class Canny : Form
    {
        private Image<Gray, Byte> img = null;
        public Canny()
        {
            InitializeComponent();
        }

        private void btnCannyLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpeg files (*.jpg)|*.jpg|(*.gif)|gif||";
            if (DialogResult.OK == dialog.ShowDialog())
            {
                this.img = new Image<Gray, Byte>(dialog.FileName); //Corner detection requires grayscale
                this.picOriginal.Image = new Bitmap(dialog.FileName);
            }
        }

        private void btnCannyApply_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Gray, Byte> result = new Image<Gray, byte>(img.Size);
                CvInvoke.Canny(image: img, edges: result, 50, 200);
                picResult.Image = result.ToBitmap();
            }catch (Exception ex)
            {
                MessageBox.Show("Please load image first.");
            }
        }
    }
}
