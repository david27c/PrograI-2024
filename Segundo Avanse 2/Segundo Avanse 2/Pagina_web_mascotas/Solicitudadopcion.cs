namespace Segundo_Avanse_2.Pagina_web_mascotas
{
    public class Solicitudadopcion
    {
        public int Id { get; set; }
        public int MascotaId { get; set; }
        public mascota Mascota { get; set; } // Relación con Mascota
        public string NombreAdoptante { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaSolicitud { get; set; }

    }
}
