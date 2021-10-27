using ReRoller.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace ReRoller.imageChecker
{
 public class Checker
    {
        //made it public  and outside of isinscreen to acces it in form image

        //makes bitmap var whit value screenshot pixels of screen
        public Bitmap screenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        
        //makes bitmap var whit value of  recource pixels
        public Bitmap myPic = Resources.lootsplosion;


        public bool IsInScreen()
        {
            //initialise and start stopwatch (timer tracks time while program runs)
            Stopwatch sw = new Stopwatch();
            sw.Start();


            //create graphics from image screen capture
            Graphics g = Graphics.FromImage(screenCapture);



            g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                             Screen.PrimaryScreen.Bounds.Y,
                             0, 0,
                             screenCapture.Size,
                             CopyPixelOperation.SourceCopy);

            //returns boolean value of isInCapturefunction(bitmap foo,bitmap foo2)
           return IsInCapture(myPic, screenCapture);

         
            //stops stopwatch
            sw.Stop();

            //time it took to run code (thus find image)
            TimeSpan ts = sw.Elapsed;
        }

        // scans the screen for pixels that are the same as your image
        private bool IsInCapture(Bitmap searchFor, Bitmap searchIn)
        {
            for (int x = 0; x < searchIn.Width; x++)
            {
                for (int y = 0; y < searchIn.Height; y++)
                {
                    bool invalid = false;
                    int k = x, l = y;
                    for (int a = 0; a < searchFor.Width; a++)
                    {
                        l = y;
                        for (int b = 0; b < searchFor.Height; b++)
                        {
                            if (searchFor.GetPixel(a, b) != searchIn.GetPixel(k, l))
                            {
                                invalid = true;
                                break;
                            }
                            else
                                l++;
                        }
                        if (invalid)
                            break;
                        else
                            k++;
                    }
                    if (!invalid)
                        return true;
                }
            }
            return false;
        }
    }
}
