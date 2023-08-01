using Tesseract;

namespace WinFormsTesseract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = new Bitmap(open.FileName);


                textBox1.Text = open.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var ocrengine = new TesseractEngine(@"C:\tmp", "rus+eng", EngineMode.Default);
            var img = Pix.LoadFromFile(textBox1.Text);
            var res = ocrengine.Process(img);
            richTextBox1.Text = res.GetText();

        }

    }
}