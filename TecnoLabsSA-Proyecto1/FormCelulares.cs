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
    public partial class FormCelulares : Form
    {
        public FormCelulares()
        {
            InitializeComponent();
        }
        
        //Se realiza click en el boton para volver a la pantalla principal
        private void BtnVolverCelu_Click_1(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            Close();
        }
    }
}
