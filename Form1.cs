using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrWindow
{
    public partial class Form1 : Form
    {
        
        public int kol2 = 0;
        public string prf;
        public int index;
        public struct baza
        {
            public string login;
            public string pas;
            public string proff;
            public string tour;
            public string date1;
            public string date2;
        }
        baza[] b = new baza[0];
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
           
            
        }

        private void Registr_Click(object sender, EventArgs e)
        {
            kol2 = 0;
            
            if(textBox1.Text=="" || textBox1.Text.Length<3)
            {
                MessageBox.Show("Логин должен состоять минимум из 3 символов");
                textBox1.Text = "";
                return;
            }
            if(textBox2.Text==""||textBox2.Text.Length<32)
            {
                MessageBox.Show("Пароль должен состоять минимум из 32 символов");
                textBox2.Text = "";
                return;
            }
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                if (textBox2.Text[i] == '!'|| textBox2.Text[i] == '_'|| textBox2.Text[i] == '+'|| textBox2.Text[i] == '@'|| textBox2.Text[i] == '$')
                {
                    kol2++;
                }
            }
            if (kol2 == 0)
            {
                MessageBox.Show("Нема нужных символов в пароле..!");
                textBox2.Text = "";
                return;
            }
           
            Array.Resize(ref b, b.Length + 1);
            b[b.Length-1].login = textBox1.Text;
            b[b.Length-1].pas = textBox2.Text;
            b[b.Length - 1].proff = prf;
            MessageBox.Show("Your log->> " + b[b.Length - 1].login + "\nYourpass->> " + b[b.Length - 1].pas + "\n" + "Your Proffesion->>" + b[b.Length - 1].proff);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            prf = comboBox1.Text;
            comboBox1.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            comboBox1.Visible = false;
            label1.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            Log.Visible = false;
            Pass.Visible = false;
            Registr.Visible = false;

            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button3.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < b.Length; i++)
            {
                if (textBox3.Text == b[i].login)
                {
                    if (textBox4.Text == b[i].pas)
                    {
                        index = i;
                        MessageBox.Show("Авторизация успешна");
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        button3.Visible = false;

                        label8.Visible = true;
                        comboBox2.Visible = true;
                        label9.Visible = true;
                        dateTimePicker1.Visible = true;
                        dateTimePicker2.Visible = true;
                        label10.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;
                        label11.Visible = true;
                        
                        
                        label11.Text = "";
                        break;
                    }
                }
                if(i == b.Length-1)
                {
                    MessageBox.Show("Ошибка при вводе логина или пароля или его не существует");
                }
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text=="")
            {
                MessageBox.Show("Выберите тур");
                return;
            }
            if(dateTimePicker1.Value.Date>dateTimePicker2.Value.Date)
            {
                MessageBox.Show("Дата отправления не может быть больше даты прибытия");
                return;
            }
            if (dateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Дата отправления не может быть меньше текущей");
                return;
            }
            if(dateTimePicker2.Value.Date<DateTime.Today)
            {
                MessageBox.Show("Дата прибытия не может быть меньше текущей");
                return;
            }
            b[index].tour = comboBox2.Text;
            b[index].date1=dateTimePicker1.Text;
            b[index].date2 = dateTimePicker2.Text;
            MessageBox.Show("Тур- >> " + b[index].tour + "Date1 - > " + b[index].date1 + " Date2 - > " + b[index].date2);
            //label11.Text = "";
            label11.Text += "Тур- >> " + b[index].tour + "Дата отправления - > " + b[index].date1 + " Дата возвращения - > " + b[index].date2+"\n";
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button3.Visible = true;

            label8.Visible = false;
            comboBox2.Visible = false;
            label9.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            label10.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label11.Visible = false;
            button2.Visible = false;
           
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;


            comboBox1.Visible = true;
            label1.Visible = true;
            textBox2.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            Log.Visible = true;
            Pass.Visible = true;
            Registr.Visible = true;

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button3.Visible = false;
        }
    }
}
