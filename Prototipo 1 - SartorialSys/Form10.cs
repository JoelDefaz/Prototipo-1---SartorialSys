﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_1___SartorialSys
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Produto Registrado con exito");
            limpiarConsola();
        }

        private void limpiarConsola()
        {
            txtID.Text = "";
            txtNombreRegistrar.Text = "";
            txtProveedorRegistrar.Text = "";
            txtCantidadRegistrar.Text = "";
            txtPrecioRegistrar.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
