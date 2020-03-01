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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnOpenCanny_Click(object sender, EventArgs e)
        {
            Canny CDetector = new Canny();
            CDetector.Show();
        }

        private void btnOpenHarris_Click(object sender, EventArgs e)
        {
            Harris HDetector = new Harris();
            HDetector.Show();
        }
    }
}
