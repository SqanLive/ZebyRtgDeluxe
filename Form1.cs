using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZebyRTGDeluxe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap image1;

        public OpenFileDialog OpenFileDialog { get; private set; }


        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                image1 = (Bitmap)pictureBox1.Image;
                BrightnessTrackBar.Value = 0;
                BrightnessLabel.Text = "Brightness";
                ContrastTrackBar.Value = 0;
                ContrastLabel.Text = "Contrast";
                GammaTrackBar.Value = 5;
                GammaLabel.Text = "Gamma";
                StretchBox.Checked = false;
                ZoomBox.Checked = false;
            }
            

            try
            {


            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
            }
            else
            {
                MessageBox.Show("Load picture first.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            BrightnessTrackBar.Value = 0;
            BrightnessLabel.Text = "Brightness";
            ContrastTrackBar.Value = 0;
            ContrastLabel.Text = "Contrast";
            GammaTrackBar.Value = 5;
            GammaLabel.Text = "Gamma";
            StretchBox.Checked = false;
            ZoomBox.Checked = false;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            image1 = (Bitmap)pictureBox1.Image;
            BrightnessTrackBar.Value = 0;
            BrightnessLabel.Text = "Brightness";
            ContrastTrackBar.Value = 0;
            ContrastLabel.Text = "Contrast";
            GammaTrackBar.Value = 5;
            GammaLabel.Text = "Gamma";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonochromaticButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap klon = (Bitmap)image1.Clone();

                BitmapData bitmapData = klon.LockBits(new Rectangle(0, 0, klon.Width, klon.Height), ImageLockMode.ReadWrite, klon.PixelFormat);

                int bytesPerPixel = Bitmap.GetPixelFormatSize(klon.PixelFormat) / 8;
                int byteCount = bitmapData.Stride * klon.Height;
                byte[] pixels = new byte[byteCount];
                IntPtr ptrFirstPixel = bitmapData.Scan0;
                Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;

                for (int y = 0; y < heightInPixels; y++)
                {
                    int currentLine = y * bitmapData.Stride;
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        int oldBlue = pixels[currentLine + x];
                        int oldGreen = pixels[currentLine + x + 1];
                        int oldRed = pixels[currentLine + x + 2];

                        pixels[currentLine + x] = (byte)(.299 * oldBlue + .587 * oldGreen + .114 * oldRed);
                        pixels[currentLine + x + 1] = (byte)(.299 * oldBlue + .587 * oldGreen + .114 * oldRed);
                        pixels[currentLine + x + 2] = (byte)(.299 * oldBlue + .587 * oldGreen + .114 * oldRed);
                    }
                }

                Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
                klon.UnlockBits(bitmapData);

                pictureBox1.Image = klon;
            }
            else
            {
                MessageBox.Show("Load picture first.");
            }
        }

        private void InvertButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap klon = (Bitmap)image1.Clone();


                BitmapData bitmapData = klon.LockBits(new Rectangle(0, 0, klon.Width, klon.Height), ImageLockMode.ReadWrite, klon.PixelFormat);

                int bytesPerPixel = Bitmap.GetPixelFormatSize(klon.PixelFormat) / 8;
                int byteCount = bitmapData.Stride * klon.Height;
                byte[] pixels = new byte[byteCount];
                IntPtr ptrFirstPixel = bitmapData.Scan0;
                Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;

                for (int y = 0; y < heightInPixels; y++)
                {
                    int currentLine = y * bitmapData.Stride;
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        int oldBlue = pixels[currentLine + x];
                        int oldGreen = pixels[currentLine + x + 1];
                        int oldRed = pixels[currentLine + x + 2];

                        pixels[currentLine + x] = (byte)(255 - oldBlue);
                        pixels[currentLine + x + 1] = (byte)(255 - oldGreen);
                        pixels[currentLine + x + 2] = (byte)(255 - oldRed);
                    }
                }

                Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
                klon.UnlockBits(bitmapData);
                pictureBox1.Image = klon;
            }
            else
            {
                MessageBox.Show("Load picture first.");
            }
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = image1;
            BrightnessTrackBar.Value = 0;
            BrightnessLabel.Text = "Brightness";
            ContrastTrackBar.Value = 0;
            ContrastLabel.Text = "Contrast";
            GammaTrackBar.Value = 5;
            GammaLabel.Text = "Gamma";
        }

        private void EmbossButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                Bitmap klon = (Bitmap)image1.Clone();
      
                BitmapData bitmapData = klon.LockBits(new Rectangle(0, 0, klon.Width, klon.Height), ImageLockMode.ReadWrite, klon.PixelFormat);

                int bytesPerPixel = Bitmap.GetPixelFormatSize(klon.PixelFormat) / 8;
                int byteCount = bitmapData.Stride * klon.Height;
                byte[] pixels = new byte[byteCount];
                IntPtr ptrFirstPixel = bitmapData.Scan0;
                Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;

                for (int y = 0; y < heightInPixels - 1; y++)
                {
                    int currentLine = y * bitmapData.Stride;
                    for (int x = 0; x < widthInBytes - 1; x = x + bytesPerPixel)
                    {
                        int oldBlue = pixels[currentLine + x];
                        int oldGreen = pixels[currentLine + x + 1];
                        int oldRed = pixels[currentLine + x + 2];

                        int newBlue = pixels[currentLine + bytesPerPixel + x];
                        int newGreen = pixels[currentLine + bytesPerPixel + x + 1];
                        int newRed = pixels[currentLine + bytesPerPixel + x + 2];

                        newBlue = Math.Min(Math.Abs(oldBlue - newBlue + 128), 255);
                        newGreen = Math.Min(Math.Abs(oldGreen - newGreen + 128), 255);
                        newRed = Math.Min(Math.Abs(oldRed - newRed + 128), 255);

                        pixels[currentLine + x] = (byte)(newBlue);
                        pixels[currentLine + x + 1] = (byte)(newGreen);
                        pixels[currentLine + x + 2] = (byte)(newRed);
                    }
                }

                Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
                klon.UnlockBits(bitmapData);


                pictureBox1.Image = klon;
            }
            else
            {
                MessageBox.Show("Load picture first.");
            }
        }

        private void SharpenButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap klon = (Bitmap)image1.Clone();

                int filterWidth = 3;
                int filterHeight = 3;
                int w = image1.Width;
                int h = image1.Height;

                double[,] filter = new double[filterWidth, filterHeight];

                filter[0, 0] = filter[0, 1] = filter[0, 2] = filter[1, 0] = filter[1, 2] = filter[2, 0] = filter[2, 1] = filter[2, 2] = -1;
                filter[1, 1] = 9;

                double factor = 1.0;
                double bias = 0.0;


                BitmapData bitmapData = klon.LockBits(new Rectangle(0, 0, klon.Width, klon.Height), ImageLockMode.ReadWrite, klon.PixelFormat);

                int bytesPerPixel = Bitmap.GetPixelFormatSize(klon.PixelFormat) / 8;
                int byteCount = bitmapData.Stride * klon.Height;
                byte[] pixels = new byte[byteCount];
                IntPtr ptrFirstPixel = bitmapData.Scan0;
                Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;

                int y2 = 0;
                for (int y = 0; y < heightInPixels; y++)
                {
                    y2++;
                    int currentLine = y * bitmapData.Stride;
                    int x2 = 0;
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {

                        x2++;

                        double red = 0.0, green = 0.0, blue = 0.0;


                        for (int filterX = 0; filterX < filterWidth; filterX++)
                        {
                            for (int filterY = 0; filterY < filterHeight; filterY++)
                            {
                                int imageX = (x2 - filterWidth / 2 + filterX + w) % w;
                                int imageY = (y2 - filterHeight / 2 + filterY + h) % h;

                                int currentLine2 = imageY * bitmapData.Stride;
                                int currentX = imageX * bytesPerPixel;

                                int oldBlue = pixels[currentLine2 + currentX];
                                int oldGreen = pixels[currentLine2 + currentX + 1];
                                int oldRed = pixels[currentLine2 + currentX + 2];


                                red += oldRed * filter[filterX, filterY];
                                green += oldGreen * filter[filterX, filterY];
                                blue += oldBlue * filter[filterX, filterY];
                            }
                            int r = Math.Min(Math.Max((int)(factor * red + bias), 0), 255);
                            int g = Math.Min(Math.Max((int)(factor * green + bias), 0), 255);
                            int b = Math.Min(Math.Max((int)(factor * blue + bias), 0), 255);

                            pixels[currentLine + x] = (byte)(b);
                            pixels[currentLine + x + 1] = (byte)(g);
                            pixels[currentLine + x + 2] = (byte)(r);
                        }
                    }
                }

                Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
                klon.UnlockBits(bitmapData);

                pictureBox1.Image = klon;

            }
            else
            {
                MessageBox.Show("Load picture first.");
            }
        }

        private void NoiseButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap klon = (Bitmap)image1.Clone();
                int windowSize = 5;


                BitmapData bitmapData = klon.LockBits(new Rectangle(0, 0, klon.Width, klon.Height), ImageLockMode.ReadWrite, klon.PixelFormat);

                int bytesPerPixel = Bitmap.GetPixelFormatSize(klon.PixelFormat) / 8;
                int byteCount = bitmapData.Stride * klon.Height;
                byte[] pixels = new byte[byteCount];
                IntPtr ptrFirstPixel = bitmapData.Scan0;
                Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;

                int row2 = 4;
                for (int row = (windowSize - 1); row < (heightInPixels - windowSize); row++)
                {
                    row2++;
                    int currentLine = row * bitmapData.Stride;
                    int column2 = 4;

                    for (int column = (windowSize - 1) * bytesPerPixel; column < (widthInBytes - windowSize * bytesPerPixel); column += bytesPerPixel)
                    {
                        column2++;
                        double sumBlue = 0;
                        double sumGreen = 0;
                        double sumRed = 0;
                        for (int i = -(windowSize - 1) / 2; i <= (windowSize - 1) / 2; i++)
                        {
                            for (int j = -(windowSize - 1) / 2; j <= (windowSize - 1) / 2; j++)
                            {
                                int currentY = (currentLine + i * bitmapData.Stride);
                                int currentX = (column + j * bytesPerPixel);

                                var blue = pixels[currentY + currentX];
                                var green = pixels[currentY + currentX + 1];
                                var red = pixels[currentY + currentX + 2];

                                sumRed = sumRed + red;
                                sumGreen = sumGreen + green;
                                sumBlue = sumBlue + blue;
                            }
                        }
                        var averageRed = (int)(sumRed / (windowSize * windowSize));
                        var averageGreen = (int)(sumGreen / (windowSize * windowSize));
                        var averageBlue = (int)(sumBlue / (windowSize * windowSize));
                        pixels[currentLine + column] = (byte)(averageBlue);
                        pixels[currentLine + column + 1] = (byte)(averageGreen);
                        pixels[currentLine + column + 2] = (byte)(averageRed);
                    }
                }
                Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
                klon.UnlockBits(bitmapData);
                pictureBox1.Image = klon;
            }
            else
            {
                MessageBox.Show("Load picture first.");
            }
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                image1 = (Bitmap)pictureBox1.Image;
                image1.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = image1;
            }
            else
            {
                MessageBox.Show("Load picture first.");
            }
        }

        private void StretchBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StretchBox.Checked)
            {
                ZoomBox.Checked = false;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void ZoomBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ZoomBox.Checked)
            {
                StretchBox.Checked = false;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void BrightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            int brightness;
            brightness = BrightnessTrackBar.Value;
            BrightnessLabel.Text = BrightnessTrackBar.Value.ToString();
            if (pictureBox1.Image != null)
            {
                try
                {
                    Bitmap klon = (Bitmap)image1.Clone();

                    BitmapData bitmapData = klon.LockBits(new Rectangle(0, 0, klon.Width, klon.Height), ImageLockMode.ReadWrite, klon.PixelFormat);

                    int bytesPerPixel = Bitmap.GetPixelFormatSize(klon.PixelFormat) / 8;
                    int byteCount = bitmapData.Stride * klon.Height;
                    byte[] pixels = new byte[byteCount];
                    IntPtr ptrFirstPixel = bitmapData.Scan0;
                    Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
                    int heightInPixels = bitmapData.Height;
                    int widthInBytes = bitmapData.Width * bytesPerPixel;

                    for (int y = 0; y < heightInPixels; y++)
                    {
                        int currentLine = y * bitmapData.Stride;
                        for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                        {
                            int oldBlue = pixels[currentLine + x];
                            int oldGreen = pixels[currentLine + x + 1];
                            int oldRed = pixels[currentLine + x + 2];

                            oldBlue = oldBlue + brightness;
                            oldGreen = oldGreen + brightness;
                            oldRed = oldRed + brightness;

                            if (oldBlue < 0) oldBlue = 1;
                            if (oldBlue > 255) oldBlue = 255;
                            if (oldGreen < 0) oldGreen = 1;
                            if (oldGreen > 255) oldGreen = 255;
                            if (oldRed < 0) oldRed = 1;
                            if (oldRed > 255) oldRed = 255;

                            pixels[currentLine + x] = (byte)(oldBlue);
                            pixels[currentLine + x + 1] = (byte)(oldGreen);
                            pixels[currentLine + x + 2] = (byte)(oldRed);
                        }
                    }

                    Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
                    klon.UnlockBits(bitmapData);

                    pictureBox1.Image = klon;


                    pictureBox1.Image = klon;
                    GammaTrackBar.Value = 5;
                    GammaLabel.Text = "Gamma";
                    ContrastTrackBar.Value = 0;
                    ContrastLabel.Text = "Contrast";

                }
                catch (ArgumentException)
                {
                    MessageBox.Show("There was an error." +
                        "Check the path to the image file.");
                }
            }
            else
            {
                MessageBox.Show("Load picture first.");
                BrightnessTrackBar.Value = 0;
                BrightnessLabel.Text = "Brightness";
            }
        }

        private void ContrastTrackBar_Scroll(object sender, EventArgs e)
        {
            double contrast;
            contrast = ContrastTrackBar.Value;
            ContrastLabel.Text = ContrastTrackBar.Value.ToString();
            contrast = (100 + contrast) / 100;
            contrast *= contrast;

            if (pictureBox1.Image != null)
            {
                try
                {
                    Bitmap klon = (Bitmap)image1.Clone();

                    BitmapData bitmapData = klon.LockBits(new Rectangle(0, 0, klon.Width, klon.Height), ImageLockMode.ReadWrite, klon.PixelFormat);

                    int bytesPerPixel = Bitmap.GetPixelFormatSize(klon.PixelFormat) / 8;
                    int byteCount = bitmapData.Stride * klon.Height;
                    byte[] pixels = new byte[byteCount];
                    IntPtr ptrFirstPixel = bitmapData.Scan0;
                    Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
                    int heightInPixels = bitmapData.Height;
                    int widthInBytes = bitmapData.Width * bytesPerPixel;

                    for (int y = 0; y < heightInPixels; y++)
                    {
                        int currentLine = y * bitmapData.Stride;
                        for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                        {
                            int oldBlue = pixels[currentLine + x];
                            int oldGreen = pixels[currentLine + x + 1];
                            int oldRed = pixels[currentLine + x + 2];

                            double newBlue = Convert.ToDouble(oldBlue) / 255.0;
                            newBlue -= 0.5;
                            newBlue *= contrast;
                            newBlue += 0.5;
                            newBlue *= 255;
                            if (newBlue < 0) newBlue = 0;
                            if (newBlue > 255) newBlue = 255;

                            double newGreen = Convert.ToDouble(oldGreen) / 255.0;
                            newGreen -= 0.5;
                            newGreen *= contrast;
                            newGreen += 0.5;
                            newGreen *= 255;
                            if (newGreen < 0) newGreen = 0;
                            if (newGreen > 255) newGreen = 255;

                            double newRed = Convert.ToDouble(oldRed) / 255.0;
                            newRed -= 0.5;
                            newRed *= contrast;
                            newRed += 0.5;
                            newRed *= 255;
                            if (newRed < 0) newRed = 0;
                            if (newRed > 255) newRed = 255;

                            pixels[currentLine + x] = (byte)((int)newBlue);
                            pixels[currentLine + x + 1] = (byte)((int)newGreen);
                            pixels[currentLine + x + 2] = (byte)((int)newRed);
                        }
                    }

                    Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
                    klon.UnlockBits(bitmapData);

                    pictureBox1.Image = klon;




                    pictureBox1.Image = klon;
                    BrightnessTrackBar.Value = 0;
                    BrightnessLabel.Text = "Brightness";
                    GammaTrackBar.Value = 5;
                    GammaLabel.Text = "Gamma";

                }
                catch (ArgumentException)
                {
                    MessageBox.Show("There was an error." +
                        "Check the path to the image file.");
                }
            }
            else
            {
                MessageBox.Show("Load picture first.");
                ContrastTrackBar.Value = 0;
                ContrastLabel.Text = "Contrast";
            }
        }

        private void GammaTrackBar_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                double gamma;
                Bitmap klon = (Bitmap)image1.Clone();
                gamma = GammaTrackBar.Value;
                gamma = gamma / 5;
                GammaLabel.Text = GammaTrackBar.Value.ToString();

                BitmapData bitmapData = klon.LockBits(new Rectangle(0, 0, klon.Width, klon.Height), ImageLockMode.ReadWrite, klon.PixelFormat);

                int bytesPerPixel = Bitmap.GetPixelFormatSize(klon.PixelFormat) / 8;
                int byteCount = bitmapData.Stride * klon.Height;
                byte[] pixels = new byte[byteCount];
                IntPtr ptrFirstPixel = bitmapData.Scan0;
                Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;

                for (int y = 0; y < heightInPixels; y++)
                {
                    int currentLine = y * bitmapData.Stride;
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        int oldBlue = pixels[currentLine + x];
                        int oldGreen = pixels[currentLine + x + 1];
                        int oldRed = pixels[currentLine + x + 2];

                        double newBlue = Convert.ToDouble(oldBlue);
                        newBlue = (255.0 * Math.Pow(newBlue / 255.0, 1.0 / gamma));

                        double newGreen = Convert.ToDouble(oldGreen);
                        newGreen = (255.0 * Math.Pow(newGreen / 255.0, 1.0 / gamma));


                        double newRed = Convert.ToDouble(oldRed);
                        newRed = (255.0 * Math.Pow(newRed / 255.0, 1.0 / gamma));

                        // calculate new pixel value
                        pixels[currentLine + x] = (byte)(newBlue);
                        pixels[currentLine + x + 1] = (byte)(newGreen);
                        pixels[currentLine + x + 2] = (byte)(newRed);
                    }
                }

                // copy modified bytes back
                Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
                klon.UnlockBits(bitmapData);

                pictureBox1.Image = klon;
                BrightnessTrackBar.Value = 0;
                BrightnessLabel.Text = "Brightness";
                ContrastTrackBar.Value = 0;
                ContrastLabel.Text = "Contrast";
            }
            else
            {
                MessageBox.Show("Load picture first.");
                GammaTrackBar.Value = 5;
                GammaLabel.Text = "Gamma";
            }
        }

        private void AutoButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap klon = (Bitmap)image1.Clone();
                int windowSize = 5;


                BitmapData bitmapData = klon.LockBits(new Rectangle(0, 0, klon.Width, klon.Height), ImageLockMode.ReadWrite, klon.PixelFormat);

                int bytesPerPixel = Bitmap.GetPixelFormatSize(klon.PixelFormat) / 8;
                int byteCount = bitmapData.Stride * klon.Height;
                byte[] pixels = new byte[byteCount];
                IntPtr ptrFirstPixel = bitmapData.Scan0;
                Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;

                //
                if (image1.Width*image1.Height<800*700)
                {
                    windowSize = 3;
                }
                //

                //Blurr
                int row2 = 4;
                for (int row = (windowSize - 1); row < (heightInPixels - windowSize); row++)
                {
                    row2++;
                    int currentLine = row * bitmapData.Stride;
                    int column2 = 4;

                    for (int column = (windowSize - 1) * bytesPerPixel; column < (widthInBytes - windowSize * bytesPerPixel); column += bytesPerPixel)
                    {
                        column2++;
                        double sumBlue = 0;
                        double sumGreen = 0;
                        double sumRed = 0;
                        for (int i = -(windowSize - 1) / 2; i <= (windowSize - 1) / 2; i++)
                        {
                            for (int j = -(windowSize - 1) / 2; j <= (windowSize - 1) / 2; j++)
                            {

                                int currentY = (currentLine + i * bitmapData.Stride);
                                int currentX = (column + j * bytesPerPixel);

                                var blue = pixels[currentY + currentX];
                                var green = pixels[currentY + currentX + 1];
                                var red = pixels[currentY + currentX + 2];

                                sumRed = sumRed + red;
                                sumGreen = sumGreen + green;
                                sumBlue = sumBlue + blue;
                            }
                        }
                        var averageRed = (int)(sumRed / (windowSize * windowSize));
                        var averageGreen = (int)(sumGreen / (windowSize * windowSize));
                        var averageBlue = (int)(sumBlue / (windowSize * windowSize));
                        pixels[currentLine + column] = (byte)(averageBlue);
                        pixels[currentLine + column + 1] = (byte)(averageGreen);
                        pixels[currentLine + column + 2] = (byte)(averageRed);
                    }
                }
                int byteCount2 = bitmapData.Stride * klon.Height;
                byte[] pixels2 = new byte[byteCount2];
                IntPtr ptrFirstPixel2 = bitmapData.Scan0;
                Marshal.Copy(ptrFirstPixel2, pixels2, 0, pixels2.Length);
                double Suma = 0;

                //Maska
                for (int y = 0; y < heightInPixels; y++)
                {
                    int currentLine = y * bitmapData.Stride;
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        int oldBlue = pixels2[currentLine + x];
                        int oldGreen = pixels2[currentLine + x + 1];
                        int oldRed = pixels2[currentLine + x + 2];

                        int blurRed = pixels[currentLine + x];
                        int blurGreen = pixels[currentLine + x + 1];
                        int blurBlue = pixels[currentLine + x + 2];

                        int R = 0, G = 0, B = 0;

                        R = oldRed - blurRed;
                        if (R < 0)
                        {
                            R = 0;
                        }
                        G = oldGreen - blurGreen;
                        if (G < 0)
                        {
                            G = 0;
                        }
                        B = oldBlue - blurBlue;
                        if (B < 0)
                        {
                            B = 0;
                        }
                        //Threshold
                        if (R < 4)
                        {
                            R = 0;
                        }
                        if (G < 4)
                        {
                            G = 0;
                        }
                        if (B < 4)
                        {
                            B = 0;
                        }
                        //
                        Suma += R;
                        pixels[currentLine + x] = (byte)(B);
                        pixels[currentLine + x + 1] = (byte)(G);
                        pixels[currentLine + x + 2] = (byte)(R);
                    }
                }
                Suma = Suma / (klon.Width * klon.Height);
                double factor = 0;
                factor = 0.7 + 2*Suma/5;
                //Dodawanie Maski
                for (int y = 0; y < heightInPixels; y++)
                {
                    int currentLine = y * bitmapData.Stride;
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        int imageBlue = pixels2[currentLine + x];
                        int imageGreen = pixels2[currentLine + x + 1];
                        int imageRed = pixels2[currentLine + x + 2];

                        int maskBlue = pixels[currentLine + x];
                        int maskGreen = pixels[currentLine + x + 1];
                        int maskRed = pixels[currentLine + x + 2];

                        int R = 0, G = 0, B = 0;
                        R = Convert.ToInt32(maskRed * factor) + imageRed; ;
                        if (R > 255)
                        {
                            R = 255;
                        }
                        G = Convert.ToInt32(maskGreen * factor) + imageGreen; ;
                        if (G > 255)
                        {
                            G = 255;
                        }
                        B = Convert.ToInt32(maskBlue * factor) + imageBlue; ;
                        if (B > 255)
                        {
                            B = 255;
                        }
                        pixels[currentLine + x] = (byte)(B);
                        pixels[currentLine + x + 1] = (byte)(G);
                        pixels[currentLine + x + 2] = (byte)(R);
                    }
                }

                //Gamma
                double gamma;
                int red2 = 0;

                for (int y = 0; y < heightInPixels; y++)
                {
                    int currentLine = y * bitmapData.Stride;
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        int red = pixels[currentLine + x + 2];
                        red2 += red;
                    }
                }

                double suma = red2;
                suma /= (image1.Height * image1.Width * 255);
                gamma = (-0.3) / Math.Log10(suma);

                for (int y = 0; y < heightInPixels; y++)
                {
                    int currentLine = y * bitmapData.Stride;
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        double blue = pixels[currentLine + x];
                        double green = pixels[currentLine + x + 1];
                        double red = pixels[currentLine + x + 2];
                        blue = (255.0 * Math.Pow(blue / 255.0, gamma));
                        green = (255.0 * Math.Pow(green / 255.0, gamma));
                        red = (255.0 * Math.Pow(red / 255.0, gamma));

                        pixels[currentLine + x] = (byte)(int)(blue);
                        pixels[currentLine + x + 1] = (byte)(int)(green);
                        pixels[currentLine + x + 2] = (byte)(int)(red);
                    }
                }


                Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
                klon.UnlockBits(bitmapData);
                pictureBox1.Image = klon;



            }
            else
            {
                MessageBox.Show("Load picture first.");
            }
        }
    
    }
}
