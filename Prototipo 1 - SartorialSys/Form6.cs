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
    public partial class frmAdministracion : Form
    {
        public frmAdministracion()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmAdministrarUsuarios usuarios = new frmAdministrarUsuarios();
            usuarios.ShowDialog();
        }

        private void btnParámetros_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            this.Close();
            frmAdministraciónParámetros parámetros = new frmAdministraciónParámetros();
            parámetros.ShowDialog();
        }
    }
}
