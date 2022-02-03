using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializacionDeObjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog() { Filter = "Archivo de datos|*.dat" };
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                Auxiliar aux = new Auxiliar();
                aux.Guardar(new Alumno()
                {
                    NumControl = txtNumControl.Text,
                    Nombre = txtNombre.Text,
                    Edad=int.Parse(txtEdad.Text)
                }, dialog.FileName);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog() { Filter = "Archivo de datos|*.dat" };
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                Auxiliar aux = new Auxiliar();
                Alumno a = aux.Cargar(dialog.FileName);
                txtNumControl.Text = a.NumControl;
                txtNombre.Text = a.Nombre;
                txtEdad.Text = a.Edad.ToString();
            }
            

        }
    }
}
