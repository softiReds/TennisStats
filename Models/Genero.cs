﻿namespace TennisStats.Models
{
    public class Genero
    {
        public int GeneroId {  get; set; }
        public string Nombre {  get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
