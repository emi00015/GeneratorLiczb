using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiczbyLosowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonPowtorzenia_Click(object sender, EventArgs e)
        {
            Random liczba = new Random();

            int n, mx, dol;
            try
            {
                n = Convert.ToInt32(textIle.Text);
                mx = Convert.ToInt32(textMax.Text);
                dol = Convert.ToInt32(textMin.Text);
                string txt = "";
                for (int i=1; i<=n; i++)
                {
                    txt += liczba.Next(dol, mx).ToString();
                    txt += "\r\n";
                }
                textBox1.Text = txt;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textIle.Clear();
            textMax.Clear();
            textMin.Clear();
        }

        private void buttonNie_Click(object sender, EventArgs e)
        {
            Random liczba = new Random();

            int n, mx, dol, r;
            try
            {
                n = Convert.ToInt32(textIle.Text);
                mx = Convert.ToInt32(textMax.Text);
                dol = Convert.ToInt32(textMin.Text);
                string txt = "";
                r = mx - dol;
                int[] tab = new int[r];
                for (int i=1; i<=n; i++)
                {
                    int x=0;
                    x = liczba.Next(dol, mx);
                    if (tab[x-dol] == 0)
                    {
                        txt += x.ToString();
                        txt += "\r\n";
                        tab[x - dol] += 1;
                    }
                    else
                    {
                        i--;
                    }
                }
                textBox1.Text = txt;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void operacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program powstał, aby ułatwić generowanie losowych liczb w dwóch wariantach - liczby mogą się powtarzać lub nie. \r\n Generowane liczby to liczby naturalne z podanego przez użytkowanika zakresu. \r\n Po ponownym naciśnięciu losowania program wygeneruje kolejne liczby w podanych przez użytkownika kryteriach.\r\n Program nie obsługuje ułamków. \r\n Autorką programu jest Emilia Plata.");
        }
    }
}
