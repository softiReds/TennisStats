namespace TennisStats.Models
{
    public class Partido
    {
        public int PartidoId { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario UsuarioGanadorId { get; set; }
        public int SetsJugados {  get; set; }
        public Usuario Usuario1Id { get; set; }
        public Usuario Usuario2Id { get; set; }

        public virtual Usuario Ganador { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual Usuario Usuario2 { get; set; }

    }
}
