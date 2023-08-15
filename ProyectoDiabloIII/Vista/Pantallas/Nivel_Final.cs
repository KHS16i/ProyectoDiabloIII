using ProyectoDiabloIII.Controlador;
using ProyectoDiabloIII.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiabloIII.Vista.Pantallas
{

    public partial class Nivel_Final : Form
    {

        #region VARIABLES GLOBALES

        Acceso_Datos objAC = new Acceso_Datos();


        private short moveDirection = 1; // 1 para mover a la derecha, -1 para mover a la izquierda
        private byte moveDistance = 5; // Distancia a mover en cada paso
        private byte totalSteps = 0; // Contador de pasos

        private string nombreHab, tipoHab;

        private double vidaPersonaje;//Vida del personaje

        private double vidaEnemigo;//Vida del enemigo

        private byte habilidad = 1;//Se guarda tipo de habilidad, por defecto la 1

        #endregion



        #region EVENTOS

        public Nivel_Final()
        {
            InitializeComponent();
            KeyDown += Nivel_Final_KeyDown;

            timer_movEnemigo.Tick += timer_movEnemigo_Tick;

            timer_Ataque1.Tick += timer_Ataque1_Tick;
            timer_Ataque2.Tick += timer_Ataque2_Tick;

            timer_estadoNormal.Tick += timer_estadoNormal_Tick;
        }

        private void Nivel_Final_Load(object sender, EventArgs e)
        {
            timer_movEnemigo.Start();
            timer_Ataque1.Start();
            timer_estadoNormal.Start();

            obtieneSalud();

            bloqueaMenu();
            obtenerHabilidad(habilidad);
        }

        private void Nivel_Final_KeyDown(object sender, KeyEventArgs e)
        {
            #region MOVIMIENTO_PERSONAJE

            int stepSize = 10; // Tamaño del paso para mover la PictureBox

            if (e.KeyCode == Keys.A)
            {
                pb_Personaje_Principal_L.BringToFront();
                pb_Personaje_Principal_R.Left -= stepSize;
                pb_Personaje_Principal_L.Left -= stepSize;
                ataque1.Left -= stepSize;
                ataque2.Left -= stepSize;
                ataque3.Left -= stepSize;
                ataque4.Left -= stepSize;
            }
            else if (e.KeyCode == Keys.D)
            {
                pb_Personaje_Principal_R.BringToFront();
                pb_Personaje_Principal_R.Left += stepSize;
                pb_Personaje_Principal_L.Left += stepSize;
                ataque1.Left += stepSize;
                ataque2.Left += stepSize;
                ataque3.Left += stepSize;
                ataque4.Left += stepSize;
            }
            else if (e.KeyCode == Keys.W)
            {
                pb_Personaje_Principal_R.Top -= stepSize;
                pb_Personaje_Principal_L.Top -= stepSize;
                ataque1.Top -= stepSize;
                ataque2.Top -= stepSize;
                ataque3.Top -= stepSize;
                ataque4.Top -= stepSize;
            }
            else if (e.KeyCode == Keys.S)
            {
                pb_Personaje_Principal_R.Top += stepSize;
                pb_Personaje_Principal_L.Top += stepSize;
                ataque1.Top += stepSize;
                ataque2.Top += stepSize;
                ataque3.Top += stepSize;
                ataque4.Top += stepSize;
            }

            #endregion


            #region ATAQUES

            if (e.KeyCode == Keys.D1)
            {
                habilidad = 1;
            }

            if (e.KeyCode == Keys.D2)
            {
                habilidad = 2;
            }

            if (e.KeyCode == Keys.D3)
            {
                habilidad = 3;
            }

            if (e.KeyCode == Keys.D4)
            {
                habilidad = 4;
            }

            #endregion

            obtenerHabilidad(habilidad);

        }

        private void pB_Menu1_Click(object sender, EventArgs e)
        {
            btn_attack_1.Enabled = true;
            btn_attack_2.Enabled = true;
            btn_attack_3.Enabled = true;
            btn_attack_4.Enabled = true;
        }

        private void Nivel_Final_Click(object sender, EventArgs e)
        {
            bloqueaMenu();
        }

        #region PERSONAJE_PRINCIPAL

        #region ESCOGER_ATAQUES

        private void btn_attack_1_Click_1(object sender, EventArgs e)
        {
            habilidad = 1;
        }

        private void btn_attack_2_Click_1(object sender, EventArgs e)
        {
            habilidad = 2;
        }

        private void btn_attack_3_Click_1(object sender, EventArgs e)
        {
            habilidad = 3;
        }

        private void btn_attack_4_Click_1(object sender, EventArgs e)
        {
            habilidad = 4;
        }

        #endregion


        #region ATAQUE_PERSONAJE


        private void Nivel_Final_MouseUp(object sender, MouseEventArgs e)
        {
            //Vuelve la imagen por defecto del personaje
            pb_Personaje_Principal_R.BringToFront();

            calculaSaludEnemigo();
        }

        private void Nivel_Final_MouseDown(object sender, MouseEventArgs e)
        {

            switch (habilidad)
            {
                case 1:

                    if (e.Button == MouseButtons.Left)
                    {
                        ataque1.BringToFront();
                        vidaEnemigo = vidaEnemigo - 150.0;
                        lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";
                    }

                    break;

                case 2:

                    if (e.Button == MouseButtons.Left)
                    {
                        ataque2.BringToFront();
                        vidaEnemigo = vidaEnemigo - 50.0;
                        lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";
                    }

                    break;

                case 3:

                    if (e.Button == MouseButtons.Left)
                    {
                        ataque3.BringToFront();
                        vidaEnemigo = vidaEnemigo - 100.0;
                        lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";
                    }

                    break;

                case 4:

                    if (e.Button == MouseButtons.Left)
                    {
                        ataque4.BringToFront();
                        vidaEnemigo = vidaEnemigo - 30.0;
                        lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";
                    }

                    break;

                default:

                    if (e.Button == MouseButtons.Left)
                    {
                        ataque1.BringToFront();
                        vidaEnemigo = vidaEnemigo - 150.0;
                        lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";
                    }

                    break;
            }
        }

        #endregion

        private void Nivel_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #region ENEMIGO

        private void timer_movEnemigo_Tick(object sender, EventArgs e)
        {
            movEnemigo1();
        }

        #region ATAQUES_ENEMIGO

        private void timer_estadoNormal_Tick(object sender, EventArgs e)
        {
            pb_enemigoAtaque1.SendToBack();
            timer_Ataque2.Start();
        }

        private void timer_Ataque1_Tick(object sender, EventArgs e)
        {
            pb_enemigoAtaque1.BringToFront();
            vidaPersonaje = vidaPersonaje - 180.0;
            lbl_vida.Text = vidaPersonaje.ToString() + "%";

            calculaSaludPersonaje();
        }

        private void timer_Ataque2_Tick(object sender, EventArgs e)
        {
            pb_enemigoAtaque2.BringToFront();
            vidaPersonaje = vidaPersonaje - 50.0;
            lbl_vida.Text = vidaPersonaje.ToString() + "%";

            calculaSaludPersonaje();
        }

        #endregion

        #endregion


        #endregion


        #region METODOS


        public void movEnemigo1()
        {

            // Mueve la PictureBox en la dirección actual
            pb_Enemigo1_R.Left += moveDirection * moveDistance;
            pb_Enemigo1_L.Left += moveDirection * moveDistance;
            pb_enemigoAtaque1.Left += moveDirection * moveDistance;
            pb_enemigoAtaque2.Left += moveDirection * moveDistance;

            // Incrementa el contador de pasos
            totalSteps++;

            // Si se han completado suficientes pasos, cambia la dirección
            if (totalSteps >= 100) // 10 pasos * 100 ms
            {
                moveDirection *= -1; // Cambia la dirección
                totalSteps = 0; // Reinicia el contador de pasos

                if (moveDirection == 1)
                {
                    pb_Enemigo1_R.Visible = true;
                    pb_Enemigo1_L.Visible = false;

                }
                else
                {
                    pb_Enemigo1_R.Visible = false;
                    pb_Enemigo1_L.Visible = true;
                }
            }
        }

        public void bloqueaMenu()
        {
            btn_attack_1.Enabled = false;
            btn_attack_2.Enabled = false;
            btn_attack_3.Enabled = false;
            btn_attack_4.Enabled = false;
        }

        public void manejaVentanas()
        {
            this.Hide();

            //Pant_Nivel_2.ShowDialog();
        }

        private void timer_movEnemigo_Tick_1(object sender, EventArgs e)
        {
            movEnemigo1();
        }

        private void timer_Ataque1_Tick_1(object sender, EventArgs e)
        {
     
            pb_enemigoAtaque1.BringToFront();
            pb_enemigoAtaque2.SendToBack();
        }

        private void timer_Ataque2_Tick_1(object sender, EventArgs e)
        {
            pb_enemigoAtaque2.BringToFront();
        }

        private void timer_estadoNormal_Tick_1(object sender, EventArgs e)
        {
            pb_enemigoAtaque1.SendToBack();
            timer_Ataque2.Start();
        }

        public void obtenerHabilidad(int idHabilidad)
        {
            List<Habilidad> list = objAC.obtenerHabilidades();

            foreach (Habilidad item in list)
            {
                if (item.idHabilidad == idHabilidad)
                {
                    nombreHab = item.nombre;
                    tipoHab = item.tipo;

                    break;
                }
            }

            lbl_NombreHab.Text = nombreHab;
            lbl_TipoHab.Text = tipoHab;
        }

        public void obtieneSalud()
        {
            if (Pantalla_Principal.presionar)
            {
                vidaPersonaje = objAC.cargarSalud(1);
                vidaEnemigo = objAC.cargarSalud(2);

                lbl_vida.Text = vidaPersonaje.ToString() + "%";
                lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";
            }
            else
            {
                vidaPersonaje = 1000.0;
                vidaEnemigo = 3000.0;
                lbl_vida.Text = vidaPersonaje.ToString() + "%";
                lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";
            }
        }

        public void calculaSaludEnemigo()
        {
            //Derrotamos al enemigo
            if (vidaEnemigo <= 0)
            {
                vidaEnemigo = 0.0;
                lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";

                timer_movEnemigo.Stop();
                timer_movEnemigo.Dispose();
                timer_Ataque1.Stop();
                timer_Ataque1.Dispose();
                timer_Ataque2.Stop();
                timer_Ataque2.Dispose();
                timer_estadoNormal.Stop();
                timer_estadoNormal.Dispose();

                pb_Enemigo1_L.Visible = false;
                pb_Enemigo1_R.Visible = false;
                pb_enemigoAtaque1.Visible = false;
                pb_enemigoAtaque2.Visible = false;

                pb_Enemigo1_derrotado.Visible = true;
                pb_Enemigo1_derrotado.BringToFront();

                MessageBox.Show("Has derrotado al increible Butcher!!\n\n       Gracias por jugar!!", "HAS PASADO EL JUEGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Exit();

            }
        }

        public void calculaSaludPersonaje()
        {
            if (vidaPersonaje <= 0)
            {
                vidaPersonaje = 0.0;
                lbl_vida.Text = vidaPersonaje.ToString() + "%";

                timer_movEnemigo.Stop();
                timer_Ataque1.Stop();
                timer_Ataque2.Stop();
                timer_estadoNormal.Stop();

                DialogResult res = MessageBox.Show("YOU DEATH!\n\nQuieres reintentarlo?", "Misión Fallida", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (res == DialogResult.Yes)
                {
                    vidaPersonaje = 1000.0;
                    vidaEnemigo = 3000.0;

                    lbl_vida.Text = vidaPersonaje.ToString() + "%";
                    lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";

                    timer_movEnemigo.Start();
                    timer_Ataque1.Start();
                    timer_estadoNormal.Start();
                }
                else
                {
                    Close();
                }
            }
        }

        #endregion

    }
}
