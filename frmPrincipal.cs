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
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();

        }
        private void LigarRelogio(Object o, EventArgs e)
        {
            p1.Text = DateTime.Now.ToString();
        }
        private void IC(Object o, EventArgs e)
        {
            
                this.Hide();
                Target_Projetos.InverteCaracteres d = new InverteCaracteres();
                d.Show();
            

        }

        private void SF(Object o, EventArgs e)
        {
            
                this.Hide();
                Target_Projetos.frmFibonacci1 c = new frmFibonacci1();
                c.Show();
                       

        }


        private void Fechar(Object o, EventArgs e)
        {
            Application.Exit();
        }


        

    }
   
    



}
