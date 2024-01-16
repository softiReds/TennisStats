namespace TennisStats.Models
{
    public class Estadistica
    {
        public int EstadisticaId { get; set; }
        public Usuario UsuarioId { get; set; }
        public int Saques {  get; set; }
        public int Dobles {  get; set; }
        public int Errores { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
