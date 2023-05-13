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
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.Security.Cryptography;
using static Emgu.CV.ML.KNearest;

namespace Smart_Home_VisitorDetectionApp
{
    public partial class apprecog : Form
    {
        #region Variables
        private Capture videoCapture = null;
        public Image<Bgr,Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool faceDetectedEnabled = false;
        CascadeClassifier classifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        #endregion
        public apprecog()
        {
            InitializeComponent();
        }

        private void Capturebtn_Click(object sender, EventArgs e)
        {
            videoCapture = new Capture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
             
            //Step 1 Video Capture 
            videoCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr,Byte>().Resize(Picbox.Width,Picbox.Height,Inter.Cubic);

            //Render the video capture into the Picture box Picbox
            
            //STEP 2 DETECT FACES
            if (faceDetectedEnabled)
            {
                //CONVERT THE BGR IMAGE TO GRAY IMAGE
                Mat greyImage = new Mat();
                CvInvoke.CvtColor(currentFrame, greyImage, ColorConversion.Bgr2Gray);
                //Ehnance the image to get better result
                CvInvoke.EqualizeHist(greyImage, greyImage);
                Rectangle[] faces = classifier.DetectMultiScale(greyImage,1.1,3,Size.Empty,Size.Empty);
                //If face detected
                if (faces.Length>0)
                {
                    foreach(var face in faces)
                    {
                        //Draw rectangle on each faces
                        CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                    }


                }

            }
            Byte[] byteimg = currentFrame.ToJpegData();
            Picbox.Image = (Bitmap)((new ImageConverter()).ConvertFrom(byteimg)); //DrawToBitmap(currentFrame);
        }

        private void Detectbtn_Click(object sender, EventArgs e)
        {
            faceDetectedEnabled = true;
        }

        private void Add_Pertsonbtn_Click(object sender, EventArgs e)
        {

        }

        private void Train_Imagebtn_Click(object sender, EventArgs e)
        {

        }

        private void Recognizebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
