using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCondicionales2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double horasTrabajadas;
            double valorHora;
            double salarioBase;
            double salud;
            double incremento;
            double salarioAPagar;

            horasTrabajadas = double.Parse(txthorastrabajadas.Text);
            valorHora = double.Parse(txtvalorhora.Text);

            salarioBase = horasTrabajadas * valorHora;

            if (salarioBase > 1000000) {
                salud = salarioBase * 0.04;
                incremento = 0;
            } else {
                salud = 0;
                incremento = salarioBase * 0.02;
            }
            salarioAPagar = salarioBase - salud + incremento;

            lblsalariobase.Text = Convert.ToString("$"+String.Format("{0:n0}", salarioBase));
            lblpagosalud.Text = Convert.ToString("$" + String.Format("{0:n0}", salud));
            lblincremento.Text = Convert.ToString("$" + String.Format("{0:n0}", incremento));
            lblsalarioapagar.Text = Convert.ToString("$" + String.Format("{0:n0}", salarioAPagar));

            gbresumenpago.Visible = true;

        }

        private void btnlimpiarcampos_Click(object sender, EventArgs e)
        {
            txthorastrabajadas.Text = String.Empty;
            txtvalorhora.Text = String.Empty;
            gbresumenpago.Visible = false;
            txthorastrabajadas.Focus();
        }
    }
}
