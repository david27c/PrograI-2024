using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Avanse
{
    public partial class Mascotas : Form
    {
        public Mascotas()
        {
            InitializeComponent();
        }
        private void Mascotas_Load(object sender, EventArgs e)
        {
            // Configuración de ventana principal
            this.Text = "Mascotas";
            this.Size = new Size(800, 600);

            // Panel para el menú lateral
            Panel menuPanel = new Panel
            {
                Size = new Size(200, this.Height),
                BackColor = Color.LightYellow,
                Dock = DockStyle.Left
            };
            this.Controls.Add(menuPanel);

            // Enlaces del menú lateral
            LinkLabel mascotasLink = new LinkLabel
            {
                Text = "Mascota",
                Location = new Point(20, 30)
            };
            LinkLabel importanciaLink = new LinkLabel
            {
                Text = "Importancia de un amigo",
                Location = new Point(20, 70)
            };
            LinkLabel refugiosLink = new LinkLabel
            {
                Text = "Refugios relacionados",
                Location = new Point(20, 110)
            };
            LinkLabel contactoLink = new LinkLabel
            {
                Text = "Nuestro Contactos",
                Location = new Point(20, 150)
            };

            menuPanel.Controls.Add(mascotasLink);
            menuPanel.Controls.Add(importanciaLink);
            menuPanel.Controls.Add(refugiosLink);
            menuPanel.Controls.Add(contactoLink);

            // Panel principal
            Panel mainPanel = new Panel
            {
                BackColor = Color.LightSteelBlue,
                Dock = DockStyle.Fill
            };
            this.Controls.Add(mainPanel);

            // Título del panel principal
            Label titleLabel = new Label
            {
                Text = "MASCOTAS",
                Font = new Font("Arial", 20, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(250, 20)
            };
            mainPanel.Controls.Add(titleLabel);

            // Ejemplo de mascotas con PictureBox
            AgregarMascota(mainPanel, "Kiara", "1 año", "Hembra", "ruta_a_la_imagen_de_perro.jpg", 50, 80);
        }

        private void AgregarMascota(Panel panel, string nombre, string edad, string genero, string imagePath, int x, int y)
        {
            // Imagen de la mascota
            PictureBox pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(100, 100),
                Location = new Point(x, y),
                ImageLocation = imagePath // Cambia esta ruta a la ubicación real de tu imagen
            };
            panel.Controls.Add(pictureBox);

            // Información de la mascota
            Label nameLabel = new Label
            {
                Text = $"Nombre: {nombre}",
                AutoSize = true,
                Location = new Point(x, y + 110)
            };
            Label ageLabel = new Label
            {
                Text = $"Edad: {edad}",
                AutoSize = true,
                Location = new Point(x, y + 130)
            };
            Label genderLabel = new Label
            {
                Text = $"Género: {genero}",
                AutoSize = true,
                Location = new Point(x, y + 150)
            };

            panel.Controls.Add(nameLabel);
            panel.Controls.Add(ageLabel);
            panel.Controls.Add(genderLabel);
        }
    }
}
