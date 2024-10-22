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
    public partial class Historia : Form
    {
        public Historia()
        {
            InitializeComponent();
        }

        private void Historia_Load(object sender, EventArgs e)
        {
            this.Text = "Historia";
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

            // Título de la historia
            Label historiaTitulo = new Label
            {
                Text = "Historia de Adopta un amigo",
                Font = new Font("Arial", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(220, 20)
            };
            mainPanel.Controls.Add(historiaTitulo);

            // Texto de la historia
            Label historiaTexto = new Label
            {
                Text = "Nació de un sueño: transformar la vida de animales abandonados. Nos asociamos con refugios locales para " +
                       "brindarles una plataforma donde puedan encontrar familias amorosas. Desde el principio, nuestro compromiso " +
                       "ha sido no solo encontrar hogares, sino asegurar que cada adopción sea la correcta para el animal y la familia. " +
                       "\"Adopta un Amigo\" ha tenido el honor de ver transformaciones increíbles. Como la de Max, un perro rescatado " +
                       "que encontró una familia perfecta después de meses en el refugio. La historia de Luna, una gatita tímida que " +
                       "ahora vive sus días explorando su nuevo hogar y recibiendo caricias. Estos ejemplos destacan el impacto positivo " +
                       "que un nuevo hogar puede tener en la vida de los animales y sus adoptantes.",
                AutoSize = true,
                Location = new Point(220, 60),
                Size = new Size(550, 120),
                Font = new Font("Arial", 10)
            };
            mainPanel.Controls.Add(historiaTexto);

            // Sección Misión
            Label misionTitulo = new Label
            {
                Text = "MISION",
                Font = new Font("Arial", 14, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(220, 200),
                ForeColor = Color.DarkBlue
            };
            mainPanel.Controls.Add(misionTitulo);

            Label misionTexto = new Label
            {
                Text = "“Nuestra misión en Adopta un Amigo es tejer hilos invisibles entre corazones humanos y patitas peludas. " +
                       "Buscamos transformar historias de abandono en cuentos de amor eterno. " +
                       "Cada adopción es un latido más fuerte, un ronroneo de gratitud y una promesa " +
                       "de compañía incondicional. " +
                       "Porque en este mundo, no hay dueños, solo amigos que se encuentran.”",
                AutoSize = true,
                Location = new Point(220, 230),
                Size = new Size(300, 100),
                Font = new Font("Arial", 10)
            };
            mainPanel.Controls.Add(misionTexto);

            // Sección Visión
            Label visionTitulo = new Label
            {
                Text = "VISION",
                Font = new Font("Arial", 14, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(500, 200),
                ForeColor = Color.DarkBlue
            };
            mainPanel.Controls.Add(visionTitulo);

            Label visionTexto = new Label
            {
                Text = "“Imaginemos un mundo donde las patitas deambulan por senderos de amor y los corazones humanos " +
                       "se llenan de ronroneos y ladridos. " +
                       "En ese mundo, Adopta un Amigo es el abrazo que conecta almas solitarias con peludos compañeros. " +
                       "Es el lugar donde los ojos cansados encuentran miradas llenas de gratitud. " +
                       "En cada adopción, vemos el futuro de juegos en el parque, siestas compartidas y lealtad inquebrantable. " +
                       "Porque en este mundo, no hay dueños, solo amigos que se eligen.”",
                AutoSize = true,
                Location = new Point(500, 230),
                Size = new Size(300, 150),
                Font = new Font("Arial", 10)
            };
            mainPanel.Controls.Add(visionTexto);
        }
    }
}
