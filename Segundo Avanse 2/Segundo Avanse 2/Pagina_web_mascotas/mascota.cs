namespace Segundo_Avanse_2.Pagina_web_mascotas
{
    public class mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; } // Ej: Perro, Gato
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public bool DisponibleParaAdopcion { get; set; }

    }
}
