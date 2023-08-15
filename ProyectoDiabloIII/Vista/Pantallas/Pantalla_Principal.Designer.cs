namespace ProyectoDiabloIII.Vista.Pantallas
{
    partial class Pantalla_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_Principal));
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btn_cargarPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.FlatAppearance.BorderSize = 5;
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Felix Titling", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Salir.Location = new System.Drawing.Point(250, 406);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(353, 61);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Iniciar.FlatAppearance.BorderSize = 5;
            this.btn_Iniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_Iniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Iniciar.Font = new System.Drawing.Font("Felix Titling", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Iniciar.Location = new System.Drawing.Point(250, 238);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(353, 61);
            this.btn_Iniciar.TabIndex = 0;
            this.btn_Iniciar.Text = "Nueva Partida";
            this.btn_Iniciar.UseVisualStyleBackColor = false;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btn_cargarPartida
            // 
            this.btn_cargarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btn_cargarPartida.FlatAppearance.BorderSize = 5;
            this.btn_cargarPartida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_cargarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_cargarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarPartida.Font = new System.Drawing.Font("Felix Titling", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargarPartida.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_cargarPartida.Location = new System.Drawing.Point(250, 320);
            this.btn_cargarPartida.Name = "btn_cargarPartida";
            this.btn_cargarPartida.Size = new System.Drawing.Size(353, 61);
            this.btn_cargarPartida.TabIndex = 2;
            this.btn_cargarPartida.Text = "Cargar Partida";
            this.btn_cargarPartida.UseVisualStyleBackColor = false;
            this.btn_cargarPartida.Click += new System.EventHandler(this.btn_cargarPartida_Click);
            // 
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(868, 529);
            this.Controls.Add(this.btn_cargarPartida);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.btn_Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pantalla_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diablo III";
            this.Load += new System.EventHandler(this.Pantalla_Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btn_cargarPartida;
    }
}