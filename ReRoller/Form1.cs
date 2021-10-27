using System;
using System.Windows.Forms;

namespace ReRoller
{
    public partial class rerollerform : Form
    {
        public rerollerform()
        {
            InitializeComponent();
        }

        private void buttonReroll_Click(object sender, EventArgs e)
        {
            imageChecker.Checker checker = new imageChecker.Checker();

            bool isInCapture =checker.IsInScreen();
            string resultMessage;
            if (isInCapture)
            {
                resultMessage = "Picture found!";
            }
            else
            {
                resultMessage = "Picture found!";
            }
            //only call labelDone.Text function 1 time to make ccode faster
            labelDone.Text= resultMessage;

            ScreenToCheckPictureBox.Image =checker.screenCapture;
            SourceImagePictureBox.Image =checker.myPic;
        }

      
    }
}

