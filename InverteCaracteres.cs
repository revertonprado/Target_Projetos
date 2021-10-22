using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target_Projetos
{
    public partial class InverteCaracteres : Form
    {
        public InverteCaracteres()
        {
            InitializeComponent();

            
        }
        public void Inverter(object sender, EventArgs e) 
        {
            string iv = "";
            int Length = 0;

            Length = txtTexto.Text.Length - 1;
            while(Length >=0)
            {
                iv = iv + txtTexto.Text[Length];
                Length--;
            }

            txtInvertido.Text = iv;
            
        }

        public void Limpar(object o, EventArgs e)
        {
            txtTexto.Clear();
            txtInvertido.Clear();
            txtTexto.Focus();

        }

        public void Sair(object o, EventArgs e)
        {
            this.Hide();
            Target_Projetos.frmTelaInicial d = new frmTelaInicial();
            d.Show();
        }







    }   
}
