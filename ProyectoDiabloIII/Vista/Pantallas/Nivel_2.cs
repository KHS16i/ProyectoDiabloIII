using ProyectoDiabloIII.Controlador;
using ProyectoDiabloIII.Modelo;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ProyectoDiabloIII.Vista.Pantallas
{
    public partial class Nivel_2 : Form
    {
        #region VARIABLES GLOBALES

        Acceso_Datos objAC = new Acceso_Datos();

        Pantallas.Nivel_Final Pant_Nivel_Final = new Nivel_Final();

        private short moveDirection = 1; // 1 para mover a la derecha, -1 para mover a la izquierda
        private byte moveDistance = 5; // Distancia a mover en cada paso
        private byte totalSteps = 0; // Contador de pasos

        private string nombreHab, tipoHab;

        private double vidaPersonaje;//Vida del personaje

        private double vidaEnemigo;//Vida del enemigo


        private byte habilidad = 1;//Se guarda tipo de habilidad, por defecto la 1

        #endregion

        #region EVENTOS

        public Nivel_2()
        {
            InitializeComponent();
            KeyDown += Nivel_2_KeyDown;


            //primer enemigo 
            timer_movEnemigo.Tick += timer_movEnemigo_Tick;
            timer_Ataque1.Tick += timer_Ataque1_Tick;
            timer_Ataque2.Tick += timer_Ataque2_Tick;
            timer_estadoNormal.Tick += timer_estadoNormal_Tick;


            //segundo enemigo 
            timer_movEnemigo2.Tick += timer_movEnemigo_Tick;
            timer_Ataque21.Tick += timer_Ataque1_Tick;
            timer_Ataque22.Tick += timer_Ataque2_Tick;
            timer_estadoNormal2.Tick += timer_estadoNormal_Tick;

        }

        private void Nivel_2_Load(object sender, EventArgs e)
        {
            //primer enemigo
            timer_movEnemigo.Start();
            timer_Ataque1 .Start();
            timer_estadoNormal.Start();

            //segundo enemigo
            timer_movEnemigo2.Start();
            timer_Ataque21.Start();
            timer_estadoNormal2.Start();

            obtieneSalud();

            bloqueaMenu();
            obtenerHabilidad(habilidad);

        }

        private void Nivel_2_KeyDown(object sender, KeyEventArgs e)
        {
            #region MOVIMIENTO_PERSONAJE

            int stepSize = 10; // Tamaño del paso para mover la PictureBox

            if (e.KeyCode == Keys.A)
            {
                pb_Personaje_PrincipalN2_L.BringToFront();
                pb_Personaje_PrincipalN2_R.Left -= stepSize;
                pb_Personaje_PrincipalN2_L.Left -= stepSize;
                ataque1_N2.Left -= stepSize;
                ataque2_N2.Left -= stepSize;
                ataque3_N2.Left -= stepSize;
                ataque4_N2.Left -= stepSize;
            }
            else if (e.KeyCode == Keys.D)
            {
                pb_Personaje_PrincipalN2_R.BringToFront();
                pb_Personaje_PrincipalN2_R.Left += stepSize;
                pb_Personaje_PrincipalN2_L.Left += stepSize;
                ataque1_N2.Left += stepSize;
                ataque2_N2.Left += stepSize;
                ataque3_N2.Left += stepSize;
                ataque4_N2.Left += stepSize;
            }
            else if (e.KeyCode == Keys.W)
            {
                pb_Personaje_PrincipalN2_R.Top -= stepSize;
                pb_Personaje_PrincipalN2_L.Top -= stepSize;
                ataque1_N2.Top -= stepSize;
                ataque2_N2.Top -= stepSize;
                ataque3_N2.Top -= stepSize;
                ataque4_N2.Top -= stepSize;
            }
            else if (e.KeyCode == Keys.S)
            {
                pb_Personaje_PrincipalN2_R.Top += stepSize;
                pb_Personaje_PrincipalN2_L.Top += stepSize;
                ataque1_N2.Top += stepSize;
                ataque2_N2.Top += stepSize;
                ataque3_N2.Top += stepSize;
                ataque4_N2.Top += stepSize;
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

        private void Nivel_2_Click(object sender, EventArgs e)
        {
            bloqueaMenu();
        }


        #region PERSONAJE_PRINCIPAL

        #region ESCOGER_ATAQUES
        private void btn_attack_1_Click(object sender, EventArgs e)
        {
            habilidad = 1;
        }

        private void btn_attack_2_Click(object sender, EventArgs e)
        {
            habilidad = 2;
        }

        private void btn_attack_3_Click(object sender, EventArgs e)
        {
            habilidad = 3;
        }

        private void btn_attack_4_Click(object sender, EventArgs e)
        {
            habilidad = 4;
        }

        #endregion

        #region ATAQUE_PERSONAJE

        private void Nivel_2_MouseDown(object sender, MouseEventArgs e)
        {

            switch (habilidad)
            {
                case 1:

                    if (e.Button == MouseButtons.Left)
                    {
                        ataque1_N2.BringToFront();
                        vidaEnemigo = vidaEnemigo - 40.0;
                        lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";
                    }

                    break;

                case 2:

                    if (e.Button == MouseButtons.Left)
                    {
                        ataque2_N2.BringToFront();
                        vidaEnemigo = vidaEnemigo - 25.0;
                        lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";
                    }

                    break;

                case 3:

                    if (e.Button == MouseButtons.Left)
                    {
                        ataque3_N2.BringToFront();
                        vidaEnemigo = vidaEnemigo - 35.0;
                        lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";
                    }

                    break;

                case 4:

                    if (e.Button == MouseButtons.Left)
                    {
                        ataque4_N2.BringToFront();
                        vidaEnemigo = vidaEnemigo - 20.0;
                        lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";
                    }

                    break;

                default:

                    if (e.Button == MouseButtons.Left)
                    {
                        ataque1_N2.BringToFront();
                        vidaEnemigo = vidaEnemigo - 40.0;
                        lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";
                    }

                    break;
            }

        }

        private void Nivel_2_MouseUp(object sender, MouseEventArgs e)
        {

            //Vuelve la imagen por defecto del personaje
            pb_Personaje_PrincipalN2_R.BringToFront();

            calculaSaludEnemigo();
        }

        #endregion

        private void Nivel_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion


        private void timer_movEnemigo21_Tick(object sender, EventArgs e)
        {
            movEnemigo21();
        }

        private void timer_movEnemigo22_Tick(object sender, EventArgs e)
        {
            movEnemigo21();
        }
        #region ATAQUES_ENEMIGO21

        private void timer_Ataque1_Tick(object sender, EventArgs e)
        {
            pb_enemigo21Ataque1.BringToFront();

            vidaPersonaje = vidaPersonaje - 20.0;
            lbl_vida.Text = vidaPersonaje.ToString() + "%";

            calculaSaludPersonaje();

        }

        private void timer_Ataque2_Tick(object sender, EventArgs e)
        {
            pb_enemigo21Ataque2.BringToFront();

            vidaPersonaje = vidaPersonaje - 10.0;
            lbl_vida.Text = vidaPersonaje.ToString() + "%";

            calculaSaludPersonaje();
        }

        #endregion

        #region ATAQUE ENEMIGO22

        private void timer_Ataque21_Tick(object sender, EventArgs e)
        {
            pb_enemigo22Ataque1.BringToFront();
            pb_enemigo22Ataque2.SendToBack();
            vidaPersonaje = vidaPersonaje - 20.0;
            lbl_vida.Text = vidaPersonaje.ToString() + "%";

            calculaSaludPersonaje();

        }

        private void timer_Ataque22_Tick(object sender, EventArgs e)
        {
            pb_enemigo22Ataque2.BringToFront();
            vidaPersonaje = vidaPersonaje - 10.0;
            lbl_vida.Text = vidaPersonaje.ToString() + "%";

            calculaSaludPersonaje();
        }

        #endregion


        private void timer_movEnemigo_Tick(object sender, EventArgs e)
        {
            movEnemigo21();
        }


        private void timer_estadoNormal_Tick(object sender, EventArgs e)
        {
            pb_enemigo21Ataque1.SendToBack();
            timer_Ataque2.Start();
        }

        private void timer_movEnemigo2_Tick(object sender, EventArgs e)
        {
            movEnemigo21();
        }

        private void timer_estadoNormal2_Tick(object sender, EventArgs e)
        {
            pb_enemigo22Ataque1.SendToBack();
            timer_Ataque22.Start();
        }


        #endregion

        #region METODOS

        public void movEnemigo21()
        {

            // Mueve la PictureBox en la dirección actual
            pb_Enemigo21_L.Left += moveDirection * moveDistance;
            pb_Enemigo21_R.Left += moveDirection * moveDistance;
            pb_enemigo21Ataque1.Left += moveDirection * moveDistance;
            pb_enemigo21Ataque2.Left += moveDirection * moveDistance;
            pb_Enemigo22_L.Left += moveDirection * moveDistance;
            pb_Enemigo22_R.Left += moveDirection * moveDistance;
            pb_enemigo22Ataque1.Left += moveDirection * moveDistance;
            pb_enemigo22Ataque2.Left += moveDirection * moveDistance;

            // Incrementa el contador de pasos
            totalSteps++;

            // Si se han completado suficientes pasos, cambia la dirección
            if (totalSteps >= 15)
            {
                moveDirection *= -1; // Cambia la dirección
                totalSteps = 0; // Reinicia el contador de pasos

                if (moveDirection == 1)
                {
                    pb_Enemigo21_R.Visible = true;
                    pb_Enemigo21_L.Visible = false;
                    pb_Enemigo22_R.Visible = true;
                    pb_Enemigo22_L.Visible = false;

                }
                else
                {
                    pb_Enemigo21_R.Visible = false;
                    pb_Enemigo21_L.Visible = true;
                    pb_Enemigo22_R.Visible = false;
                    pb_Enemigo22_L.Visible = true;
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

            Pant_Nivel_Final.ShowDialog();
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
            vidaPersonaje = 500.0;
            vidaEnemigo = 1200.0;
            lbl_vida.Text = vidaPersonaje.ToString() + "%";
            lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";

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

                timer_movEnemigo2.Stop();
                timer_movEnemigo2.Dispose();
                timer_Ataque21.Stop();
                timer_Ataque21.Dispose();
                timer_Ataque22.Stop();
                timer_Ataque22.Dispose();
                timer_estadoNormal2.Stop();
                timer_estadoNormal2.Dispose();

                pb_Enemigo21_L.Visible = false;
                pb_Enemigo21_R.Visible = false;
                pb_enemigo21Ataque1.Visible = false;
                pb_enemigo21Ataque2.Visible = false;

                pb_Enemigo22_L.Visible = false;
                pb_Enemigo22_R.Visible = false;
                pb_enemigo22Ataque1.Visible = false;
                pb_enemigo22Ataque2.Visible = false;


                pb_Enemigo21_derrotado.Visible = true;
                pb_Enemigo21_derrotado.BringToFront();

                pb_Enemigo22_derrotado.Visible = true;
                pb_Enemigo22_derrotado.BringToFront();

                DialogResult res = MessageBox.Show("Has derrotado a todos los enemigos!!\n\nQuieres continuar?", "Misión Cumplida", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (res == DialogResult.Yes)
                {
                    manejaVentanas();
                }
                else if (res == DialogResult.No)
                {
                    Close();
                }

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

                timer_movEnemigo2.Stop();
                timer_Ataque21.Stop();
                timer_Ataque22.Stop();
                timer_estadoNormal2.Stop();

                DialogResult res = MessageBox.Show("YOU DEATH!\n\nQuieres reintentarlo?", "Misión Fallida", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (res == DialogResult.Yes)
                {
                    vidaPersonaje = 500.0;
                    vidaEnemigo = 1200.0;

                    lbl_vida.Text = vidaPersonaje.ToString() + "%";
                    lbl_saludEnemigo.Text = vidaEnemigo.ToString() + "%";

                    timer_movEnemigo.Start();
                    timer_Ataque1.Start();
                    timer_Ataque2.Start();
                    timer_estadoNormal.Start();

                    timer_movEnemigo2.Start();
                    timer_Ataque21.Start();
                    timer_Ataque22.Start();
                    timer_estadoNormal2.Start();
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
