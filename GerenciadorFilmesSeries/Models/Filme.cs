using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorFilmesSeries.Models
{
    public class Filme
    {
        public string Nome { get; set; }
        public Tema Tema { get; set; }
        public List<Artista> Artistas = new List<Artista>();

        public Filme(string nome, Tema tema)
        {
            this.Nome = nome;
            this.Tema = tema;
        }

        public void adicionaArtista(Artista artista)
        {
            this.Artistas.Add(artista);
        }
    }
}