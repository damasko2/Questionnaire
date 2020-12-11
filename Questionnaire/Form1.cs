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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_quest f2 = new form_quest();
            Quest quest= new Quest();

            if (f2.ShowDialog()==DialogResult.OK)
            {
                quest = f2.Finish();

                //Запись файла
                StreamWriter fout = new StreamWriter(@"..\..\QuestFile.txt", true);
                fout.Write(quest.ToString());
                fout.Close();

                MessageBox.Show("Файл успешно записан", "Информация", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            if (f2.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show("уопрува");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            if (f3.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show("уопрува");
            }
        }
    }
}
