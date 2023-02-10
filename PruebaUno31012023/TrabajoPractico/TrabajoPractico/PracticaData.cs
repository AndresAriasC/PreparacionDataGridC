using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class PracticaData : Form
    {
        private int n = 0;
        public PracticaData()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double inversion, ingresos, egresos, UAI, UDI, dep, Imp;
            String a, b, c;
            a = campoInventarioInicial.Text;
            b = campoIngresos.Text;
            c = campoEgresos.Text;
            if (a != "" && b!= "" && c != "")
            {
                inversion = Convert.ToDouble(campoInventarioInicial.Text);
                ingresos = Convert.ToDouble(campoIngresos.Text);
                egresos = Convert.ToDouble(campoEgresos.Text);

                if (inversion >= 5000 || inversion <= 65000)
                {
                    if (ingresos > egresos)
                    {
                        ingresos = ingresos * 60;
                        egresos = egresos * 60;
                        dep = inversion / 5;
                        UAI = ingresos - (egresos + dep);
                        Imp = UAI * 0.3;
                        UDI = UAI - Imp;

                        campoImpuesto.Text = Imp.ToString();
                        campoUAI.Text = UAI.ToString();
                        campoUDI.Text = UDI.ToString();
                       campoDepre.Text = dep.ToString();

                    }
                    else
                    {
                        MessageBox.Show("El egreso no puede ser mayor que la utilidad");
                        campoEgresos.Clear();
                        campoEgresos.Focus();

                    }
                }
                else {
                    MessageBox.Show("La inversion debe de ser mayor a 5 mil");
                    campoInventarioInicial.Clear();
                    campoInventarioInicial.Focus();
                }
            }
            else {
                MessageBox.Show("Los campos son obligatorios");
                campoInventarioInicial.Focus();
            }

            //se adiciona un reglon (una fila)
            int n = tablaRegistro.Rows.Add();

            tablaRegistro.Rows[n].Cells[0].Value = campoInventarioInicial.Text;
            tablaRegistro.Rows[n].Cells[1].Value = campoIngresos.Text;
            tablaRegistro.Rows[n].Cells[2].Value = campoEgresos.Text;
            tablaRegistro.Rows[n].Cells[3].Value = campoUAI.Text;
            tablaRegistro.Rows[n].Cells[4].Value = campoImpuesto.Text;
            tablaRegistro.Rows[n].Cells[5].Value = campoUDI.Text;
            tablaRegistro.Rows[n].Cells[6].Value = campoDepre.Text;

            campoInventarioInicial.Clear();
            campoIngresos.Clear();
            campoEgresos.Clear();
            campoDepre.Clear();
            campoImpuesto.Clear();
            campoUAI.Clear();
            campoUDI.Clear();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            campoInventarioInicial.Clear();
            campoIngresos.Clear();
            campoEgresos.Clear();
            campoDepre.Clear();
            campoImpuesto.Clear();
            campoUAI.Clear();
            campoUDI.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tablaRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                info.Text = (String)tablaRegistro.Rows[n].Cells[1].Value;
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (n != -1)
            {

                tablaRegistro.Rows.RemoveAt(n);
            }
        }

       
    }
}
