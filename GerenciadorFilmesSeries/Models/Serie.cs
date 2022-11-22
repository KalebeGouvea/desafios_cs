using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorFilmesSeries.Models
{
    public class Serie : Filme
    {
        public int Temporada { get; set; }
        public int Episodio { get; set; }
        public string Titulo { get; set; }
        public Serie(string nome, Tema tema, int temporada, int episodio, string titulo) : base(nome, tema)
        {
            this.Episodio = episodio;
            this.Titulo = titulo;
        }
    }
}