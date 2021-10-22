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
    public partial class frmFibonacci1 : Form
    {
        public frmFibonacci1()
        {
            InitializeComponent();
            
        }
        public int resultadofinal1;
        public int resultadofinal2;
        public int numero;
        private void VerificarNumero(object o, EventArgs e)
        {


            if (txtnumero.Text == string.Empty)
            {
                MessageBox.Show("Digite um número");
            }
            else
            {
                numero = Convert.ToInt32(txtnumero.Text);
                resultadofinal1 = (5 * (numero * numero) + 4);
                resultadofinal2 = (5 * (numero * numero) - 4);

                if (Convert.ToInt32(Math.Ceiling(Math.Sqrt(resultadofinal1))) == Convert.ToInt32(Math.Floor(Math.Sqrt(resultadofinal1))))
                {
                    MessageBox.Show("O número faz parte da sequência");
                }
                else if (Convert.ToInt32(Math.Ceiling(Math.Sqrt(resultadofinal2))) == Convert.ToInt32(Math.Floor(Math.Sqrt(resultadofinal2))))
                {
                    MessageBox.Show("O número faz parte da sequência");
                }
                else
                {
                    MessageBox.Show("O número não faz parte da sequência");
                }

                if (MessageBox.Show("Deseja ver a sequência?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)

                {

                    Sequencia();
                    txtnumero.Clear();
                }
                else
                {
                    txtnumero.Clear();
                }

            }
        }

        public static IEnumerable<long> Fibonacci(int n)
        {
            long primeirotermo = 0;
            long segundotermo = 1;

            for (int i = 0; i < n; i++)
            {
                yield return primeirotermo;

                long sum = primeirotermo;
                primeirotermo = segundotermo;
                segundotermo = sum + segundotermo;
            }
        }

        static void Sequencia()
        {
            MessageBox.Show(string.Join(System.Environment.NewLine, Fibonacci(40)));
        }
        public void Sair(object o, EventArgs e)
        {
            this.Hide();
            Target_Projetos.frmTelaInicial d = new frmTelaInicial();
            d.Show();
        }


    }
}
