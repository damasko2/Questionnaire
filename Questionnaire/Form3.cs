using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Questionnaire
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files(*.txt)|*.txt";

            if (openFile.ShowDialog()==DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFile.FileName);

                richTextBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files(*.txt)|*.txt";

            if (saveFile.ShowDialog()==DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFile.FileName);

                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.ForeColor = colorDialog1.Color;
                streamWriter.Write(richTextBox1.Text);
                streamWriter.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = richTextBox1.SelectionFont;
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.BackColor;

            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }

        }
    }
}
