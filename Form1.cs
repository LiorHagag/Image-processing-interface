using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Assigment2
{
    public partial class Form1 : Form
    {
        // simple create original's file bitmap
        protected Bitmap getOriginalPic()
        {
            Bitmap Originalpic = new Bitmap(FileNameText.Text);
            return Originalpic;
        }

        //the convolution selector - based on combo box choose
        protected double[,] getSelectedConvolutionAction(double[,] filter)
        {
            if (ConvoluionBox.Text == "Smooth")
            {
                 filter =  new double[,] { { 1,2, 1 }, {2, 4, 2 }, { 1, 2, 1 } };
            }
            else if (ConvoluionBox.Text == "Sharpen")
            {
                filter = new double[,] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
            }
            else if (ConvoluionBox.Text == "Vertical")
            {
                filter = new double[,] { { 1, 0, -1 }, { 1, 0, -1 }, { 1, 0, -1 } };
            }
            else if (ConvoluionBox.Text == "Horizontal")
            {
                filter = new double[,] { { 1,1,1 }, {0,0,0 }, { -1, -1, -1 } };
            }
            else 
            {
                clearAll();
                filter = null;   
            }

            return filter;
        }

        //the selector - based on combo box choose
        protected Byte getSelectedColor(Color c)
        {
            
            Byte SelectedColor = 0;
            if (ColorChoose.Text == "Blue")
            {
                SelectedColor = c.B;
            }
            else if (ColorChoose.Text == "Green")
            {
                SelectedColor = c.G;
            }
            else if (ColorChoose.Text == "Red")
            {
                SelectedColor = c.R;
            }
          
                return SelectedColor;
        }
        protected void clearAll()
        {
            uploadedFile.Image = null;
            PicAfterChange.Image = null;
            FileNameText.Text = null;
            LoadingLine.Value = LoadingLine.Minimum;
        }
        //constructor
        public Form1()
        {
            InitializeComponent();
            int Blue = ColorChoose.Items.Add("Blue");
            int Green = ColorChoose.Items.Add("Green");
            int Red = ColorChoose.Items.Add("Red");
            int Sharpen = ConvoluionBox.Items.Add("Sharpen");
            int Smooth = ConvoluionBox.Items.Add("Smooth");
            int Vertical = ConvoluionBox.Items.Add("Vertical");
            int Horizontal = ConvoluionBox.Items.Add("Horizontal");
        }

        //turn on the processBar on any button you want
        private void addLoadProcess()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += LoadingLine_Click;
            bw.WorkerReportsProgress = true;
            bw.ProgressChanged += ChangeProgressBar;
            bw.RunWorkerAsync();
        }

        //upload img to convert
        private void UploadBT_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            ofd.ShowDialog();
            FileNameText.Text = ofd.FileName;  
        }

        //load the uploaded img
        private void LoadBT_Click(object sender, EventArgs e)
        {
            try { 
            uploadedFile.Image = getOriginalPic();
            uploadedFile.SizeMode = PictureBoxSizeMode.StretchImage;
        }
            catch {
                MessageBox.Show(
"Please Upload an Image",
"Error",
MessageBoxButtons.OK,
MessageBoxIcon.Warning

);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //takes any pixel's RGB and replace it with the avarage -> makes the image grey
        private void GreyBT_Click(object sender, EventArgs e)
        {
            try
            {
                addLoadProcess();
                Bitmap originalPic = getOriginalPic();
                Bitmap d;
                for (int i = 0; i < originalPic.Width; i++)
                {
                    for (int j = 0; j < originalPic.Height; j++)
                    {
                        Color c = originalPic.GetPixel(i, j);
                        byte gray = (byte)((c.R + c.G + c.B) / 3);
                        //Set the color of this pixel
                        originalPic.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                    }
                }


                PicAfterChange.Image = originalPic;
                PicAfterChange.SizeMode = PictureBoxSizeMode.StretchImage;
            }catch (Exception)
            {
                MessageBox.Show(
"Please Load an Image",
"GreyScale Error",
MessageBoxButtons.OK,
MessageBoxIcon.Warning

);

            }
        }

        private void FileNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void uploadedFile_Click(object sender, EventArgs e)
        {

        }

        private void PicAfterChange_Click(object sender, EventArgs e)
        {

        }

        private void RemoveeColor_Click(object sender, EventArgs e)
        {
            try
            {
                addLoadProcess();
                Bitmap OriginalPic = getOriginalPic();
                //the replacement color
                Color newColor = Color.Black;
                //the original color
                Color actualColor;
                Bitmap newBitmap = new Bitmap(OriginalPic.Width, OriginalPic.Height);

                for (int i = 0; i < OriginalPic.Width; i++)
                {
                    for (int j = 0; j < OriginalPic.Height; j++)
                    {
                        Color pic_colors = OriginalPic.GetPixel(i, j);
                        byte max = Math.Max(Math.Max(pic_colors.R, pic_colors.G), pic_colors.B);
                        byte min = Math.Min(Math.Min(pic_colors.R, pic_colors.G), pic_colors.B);
                        actualColor = OriginalPic.GetPixel(i, j);

                        //identifies whether to change the specific fix or not
                        bool replace =
                          getSelectedColor(pic_colors) != min
                           && (getSelectedColor(pic_colors) == max
                           || max - getSelectedColor(pic_colors) < 8)
                           && (max - min) > 96;

                       
                        if (replace)
                        {
                            newBitmap.SetPixel(i, j, newColor);
                        }

                        else
                        {
                            newBitmap.SetPixel(i, j, actualColor);
                        }

                    }
                }
                PicAfterChange.Image = newBitmap;
                PicAfterChange.SizeMode = PictureBoxSizeMode.StretchImage;
            }catch (Exception)
            {
                MessageBox.Show(
"Please Load an Image and select a color to continue ",
"RemoveColor Error",
MessageBoxButtons.OK,
MessageBoxIcon.Warning

);
                clearAll();
            }
        }

        private void ClearImageBT_Click(object sender, EventArgs e)
        {
           clearAll();
        }

        private void convolution_Click(object sender, EventArgs e)
        {
            try
            {
                addLoadProcess();
                Bitmap originalPic = getOriginalPic();
                Color[,] result = new Color[originalPic.Width, originalPic.Height];
                int filterWidth = 3;
                int filterHeight = 3;
                int w = originalPic.Width;
                int h = originalPic.Height;
                double[,] filter = new double[filterWidth, filterHeight];
                double[,] selected = getSelectedConvolutionAction(filter);
                //kernel matrix alternative 
                filter = selected;
                // makes the value more accurate 
                double factor = 1.0;
                double bias = 0.0;

                for (int x = 0; x < w; ++x)
                {
                    for (int y = 0; y < h; ++y)
                    {
                        double red = 0.0, green = 0.0, blue = 0.0;

                        for (int filterX = 0; filterX < filterWidth; filterX++)
                        {
                            for (int filterY = 0; filterY < filterHeight; filterY++)
                            {
                                int imageX = (x - filterWidth / 2 + filterX + w) % w;
                                int imageY = (y - filterHeight / 2 + filterY + h) % h;

                                Color imageColor = originalPic.GetPixel(imageX, imageY);
                                red += imageColor.R * filter[filterX, filterY];
                                green += imageColor.G * filter[filterX, filterY];
                                blue += imageColor.B * filter[filterX, filterY];
                            }
                            int r = Math.Min(Math.Max((int)(factor * red + bias), 0), 255);
                            int g = Math.Min(Math.Max((int)(factor * green + bias), 0), 255);
                            int b = Math.Min(Math.Max((int)(factor * blue + bias), 0), 255);

                            result[x, y] = Color.FromArgb(r, g, b);
                        }
                    }
                }

                for (int i = 0; i < w; ++i)
                {
                    for (int j = 0; j < h; ++j)
                    {
                        originalPic.SetPixel(i, j, result[i, j]);
                    }
                }
                PicAfterChange.Image = originalPic;
                PicAfterChange.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception) 
            {
                
                MessageBox.Show(
"Please Load an Image and select method to continue",
"Convolution Error",
MessageBoxButtons.OK,
MessageBoxIcon.Warning

);
                clearAll();
            }
        }
        private void ChangeProgressBar(Object sendler, ProgressChangedEventArgs e)
        {
            LoadingLine.Value = e.ProgressPercentage;
        }

        private void LoadingLine_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;
            double max = 10000000;
            for (int i = 0; i < max; i++)
            {
                if (i % 1000 == 0)
                {
                    bw.ReportProgress((int)((i / max) * 100));
                }
            } 
        }

        private void ColorChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MouseMove_Click(object sender, EventArgs e)
        {


        }

        private void MouseMove_DragOver(object sender, DragEventArgs e)
        {

        }

        private void MouseMove_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void MouseMove_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void uploadedFile_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap b = getOriginalPic();
                int ImageX = e.X * b.Width / uploadedFile.Width;
                int ImageY = e.Y * b.Height / uploadedFile.Height;
                Color c = b.GetPixel(ImageX, ImageY);
                MouseMove.Text = "Pixels under the mouse: " + "(" + ImageX + " , " + ImageY + ") = < " + c.R.ToString() + " ," + c.G.ToString() + " ," + c.B.ToString() + " >";
            }
            catch (Exception) { MouseMove.Text = "please load an image to continue"; }
        }

      

        private void ConvoluionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

