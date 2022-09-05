using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_37450_37465_Lista03_Ex10
{
    public partial class frm_37450_37465_Lista03_Ex10 : Form
    {
        public frm_37450_37465_Lista03_Ex10()
        {
            InitializeComponent();
        }


        double peso = 0.0, altura = 0.0, resultado = 0.0, r = 0.0;

        private void bttverifcar_Click(object sender, EventArgs e)
        {
            try
            {
                NEntrada();
            }
            catch
            {
                MessageBox.Show("Erro nos dados!!", "Erro!!!", MessageBoxButtons.OK);
                Limpar();
                return;
            }

            NEntrada();
            if (cmdsexo.Text == "Feminino")
            {
                r = peso / Math.Pow(altura, 2);
                if (r < 19)
                {
                    resultado = r;
                    txtresultado.Text = "Seu IMC é: " + Math.Round(resultado, 2) + "Você está abaixo do peso";  
                }
                else
                {
                    if (r < 24)
                    {
                        resultado = r;
                        txtresultado.Text = "Seu IMC é: " + Math.Round(resultado, 2) + "  Você está no peso ideal";
                    }
                    else
                    {
                        if (r >= 24)
                        {
                            resultado = r;
                            txtresultado.Text = "Seu IMC é: " + Math.Round(resultado, 2) + "Você está acima do peso";
                        }
                    }
             
                }
            }
            if (cmdsexo.Text == "Masculino")
            {
                r = peso / Math.Pow(altura, 2);

                if (r < 20)
                {
                    resultado = r;
                    txtresultado.Text = "Seu IMC é: " + Math.Round(resultado, 2) + "Você está abaixo do peso"; 
                }
                else
                {
                    if (r < 25)
                    {
                        resultado = r;
                        txtresultado.Text = "Seu IMC é: " + Math.Round(resultado, 2) + "Você está no peso ideal";

                    }
                    else if (r >= 25)
                    {
                        resultado = r;
                        txtresultado.Text = "Seu IMC é: " + Math.Round(resultado, 2) + "Você está acima do peso";
                    }
                }
            }
        }

        private void NEntrada()
        {
            
            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Calculadora", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            cmdsexo.Text = "";
            txtresultado.Clear();
            txtpeso.Clear();
            txtaltura.Clear();
            
        }

        private void cmdsexo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
