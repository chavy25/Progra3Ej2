using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progra3Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Programacion III";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

            txtEntrada.Text = "Hola Malaka";
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool booleano = true;
            txtBool.Text = booleano.ToString();
            string myString = "HOOOOOOOOOOOOOOLAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            txtTercero.Text = myString;

            int[] arregloBi = { 5, 10, 12 };
            foreach (int num in arregloBi)
            {
                
                txtCuarto.Text+= " "+ num.ToString();
            }
           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtBool.Text = "";
            txtCuarto.Text = "";
            txtEntrada.Text = "";
            txtTercero.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
