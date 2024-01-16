namespace TennisStats.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public Genero GeneroId { get; set; }
        public string CorreoElectronico {  get; set; }
        public string Contraseña {  get; set; }

        public virtual Genero Genero { get; set; }
    }
}
