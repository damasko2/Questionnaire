using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire
{
    public partial class form_quest : Form
    {
        public form_quest()
        {
            InitializeComponent();
            Quest quest = new Quest();

            comboBox1.Items.AddRange(new object[] { "Украина", "Китай", "США" });
        }

        private bool Check()
        {
            if (textBox1.Text==""||textBox2.Text==""||textBox3.Text==""||
                comboBox1.Text==""||comboBox2.Text==""||maskedTextBox1.Text==""||
                (radioButton1.Checked==false&&radioButton2.Checked==false))
            {
                return false;
            }

            return true;
        }
        private string ret_rad()
        {
            if (radioButton1.Checked==true)
            {
                return "Мужской";
            }
            else
            {
                return "Женский";
            }
        }
        public Quest Finish()
        {
            Quest quest = new Quest();
            quest.Start(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text,
                comboBox2.Text, maskedTextBox1.Text, dateTimePicker1.Value.ToString(),
                ret_rad());

            return quest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                MessageBox.Show($"{textBox1.Text}\n{textBox2.Text}\n{textBox3.Text}\n\n" +
                                $"{comboBox1.Text}\n{comboBox2.Text}\n{maskedTextBox1.Text}\n\n" +
                                $"{dateTimePicker1.Value}\n\n{ret_rad()}","Информация",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не все поля заполненые!!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Не все поля заполненые!!!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem.ToString() == "Украина")
            {
                comboBox2.Items.AddRange(new object[] { "Киев", "Запорожье", "Мелитополь" });

            }
            else if (comboBox1.SelectedItem.ToString() == "Китай")
            {
                comboBox2.Items.AddRange(new object[] { "Пекин", "Шанхай", "Гуанчжоу" });
            }
            else if (comboBox1.SelectedItem.ToString() == "США")
            {
                comboBox2.Items.AddRange(new object[] { "Нью-Йорк", "Лос-Анджелес", "Чикаго" });
            }
        }
    }
}
