﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnoLabsSA_Proyecto1
{
    public partial class FormNotebooks : Form
    {
        public FormNotebooks()
        {
            InitializeComponent();
        }

        //Se realiza click en el boton para volver a la pantalla principal
        private void BtnVolverNotebooks_Click(object sender, EventArgs e)
        {
            FormInicio main = new FormInicio();
            // panelPrincipal.Visible = false;
            //PanelContenedor.Visible = true;
            main.Show();
            this.Close();
        }

        private void FormNotebooks_Load(object sender, EventArgs e)
        {

        }
    }
}
