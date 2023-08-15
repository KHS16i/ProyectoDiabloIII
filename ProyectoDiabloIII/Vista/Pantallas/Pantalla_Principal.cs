using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDiabloIII.Controlador;
using ProyectoDiabloIII.Modelo;

namespace ProyectoDiabloIII.Vista.Pantallas
{
    public partial class Pantalla_Principal : Form
    {
        #region VARIABLES LOCALES

        Acceso_Datos obj = new Acceso_Datos();

        public static bool presionar;

        Pantallas.Nivel_1 Pant_Nivel_1 = new Nivel_1();

        #endregion


        #region EVENTOS

        public Pantalla_Principal()
        {
            InitializeComponent();
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            manejaVentanas();
        }

        private void btn_cargarPartida_Click(object sender, EventArgs e)
        {
            presionar = true;

            manejaVentanas();
        }

        #endregion



        #region METODOS

        public void manejaVentanas()
        {
            try
            {
                this.Hide();

                Pant_Nivel_1.ShowDialog();

                this.Show();
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }

        #endregion

    }
}
