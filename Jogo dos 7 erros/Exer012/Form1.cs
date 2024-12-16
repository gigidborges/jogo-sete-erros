using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer012
{
    public partial class Form1 : Form
    {
        int contaerro = 0;
        int tempo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Lbl1_Click(object sender, EventArgs e)
        {
            Label mio = sender as Label;
            //verifica se o label ja foi clicado
            if (mio.Text !="")
            {
                MessageBox.Show("Tente localizar outro erro!!");
                return;
            }

            mio.Text = "X";
            contaerro += 1;
            LblPlacar.Text = contaerro.ToString();
            if(contaerro >=7)
            {
                timer1.Enabled = false;
               

                MessageBox.Show("Você achou os 7 erros!!!");


            }



        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            tempo += 1;
            LblTempo.Text = tempo.ToString();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            tempo = 0;
            contaerro = 0;
            LblPlacar.Text = "0";
            LblTempo.Text = "0";
            btnNovo.Enabled = true;
            btnInicio.Enabled = false;
            timer1.Enabled = true;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            tempo = 0;
            contaerro = 0;
            panel1.Enabled = false;
            LblPlacar.Text = "0";
            LblTempo.Text = "0";
            Lbl1.Text = "";
            Lbl2.Text = "";
            Lbl3.Text = "";
            Lbl4.Text = "";
            Lbl5.Text = "";
            Lbl6.Text = "";
            Lbl7.Text = "";
            panel1.Enabled = true;
            btnInicio.Enabled = false;
        }
    }
}
