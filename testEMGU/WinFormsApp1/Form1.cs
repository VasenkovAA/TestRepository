using Emgu;
using Emgu.CV.Util;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string partToFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            partToFile = textBox1.Text;
            pictureBox1.Image = Image.FromFile(partToFile);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                String t = "rus";
                Tesseract tmp = new Tesseract(@"C:\tmp", t, OcrEngineMode.TesseractLstmCombined);
                tmp.SetImage(new Image<Bgr, byte>(partToFile));
                tmp.Recognize();
                richTextBox1.Text = tmp.GetUTF8Text();
                tmp.Dispose();
                stopwatch.Stop();
                textBox2.Text = stopwatch.Elapsed.ToString();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.InnerException.ToString();
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                partToFile = openFileDialog1.FileName;
                textBox1.Text = partToFile;
            }
        }
    }
}