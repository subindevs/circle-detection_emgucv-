using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;

namespace camstart
{
    public partial class Form1 : Form
    {
        Capture capture;
        Image<Bgr, Byte> imgOrg;
        public Form1()
        {
            InitializeComponent();
            Run();

        }

        private void Run()
        {
            try
            {
                capture = new Capture();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
                return;
            }
            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
             imgOrg = capture.QueryFrame().ToImage<Bgr, Byte>();
             imageBox1.Image = imgOrg;
            // imageBox1.Image = capture.QueryFrame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
