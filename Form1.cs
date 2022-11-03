using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrWindow
{
    public partial class Form1 : Form
    {

        public int kol = 0;
        public int kol2 = 0;
        struct baza
        {
            public string login;
            public string pas;
            public string proff;
        }
        baza[] b = new baza[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
           
            
        }

        private void Registr_Click(object sender, EventArgs e)
        {
            kol2 = 0;
            b[kol].login = textBox1.Text;
            b[kol].pas = textBox2.Text;
            if(textBox1.Text=="" || textBox1.Text.Length<3)
            {
                MessageBox.Show("Логин должен состоять минимум из 3 символов");
                textBox1.Text = "";
                return;
            }
            if(textBox2.Text==""||textBox2.Text.Length<9)
            {
                MessageBox.Show("Пароль должен состоять минимум из 9 символов");
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
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("Your log->> " + b[kol].login + "\nYourpass->> "+ b[kol].pas+"\n"+"Your Proffesion->>" + b[kol].proff );
            kol++;
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            b[kol].proff = comboBox1.Text;
            comboBox1.Text = "";
        }
    }
}
