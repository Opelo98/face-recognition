using Emgu.CV;
using System;
using System.Windows.Forms;
using VisioForge.Shared.Accord.Vision.Detection;


namespace FaceRecognition111
{
    public partial class Form1 : Form
    {
        //Declare variables
        HaarCascade faceDetected;
        public Form1()
        {
            InitializeComponent();
            faceDetected = new HaarCascade("haarcascade_frontalface_default.xml.xml");
        }

        private void start_click(object sender, EventArgs e)
        {

        }

    }
}
