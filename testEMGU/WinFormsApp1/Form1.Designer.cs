namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            button4 = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBox2 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(361, 49);
            button1.Name = "button1";
            button1.Size = new Size(317, 34);
            button1.TabIndex = 0;
            button1.Text = "подгрузить в буфер";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 89);
            button2.Name = "button2";
            button2.Size = new Size(666, 54);
            button2.TabIndex = 1;
            button2.Text = "Распознать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(38, 228);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(538, 31);
            textBox1.TabIndex = 3;
            textBox1.Text = "C:\\Users\\user\\Downloads\\Удалить.jpg";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(693, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(868, 877);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 204);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(666, 688);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 7;
            label1.Text = "Путь к файлу:";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 49);
            button4.Name = "button4";
            button4.Size = new Size(292, 34);
            button4.TabIndex = 8;
            button4.Text = "Открыть диалоговое окно";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(86, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 31);
            textBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 158);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 10;
            label2.Text = "Время:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1573, 901);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button button4;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox2;
        private Label label2;
    }
}