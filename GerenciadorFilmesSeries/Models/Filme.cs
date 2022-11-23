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

        public bool filtra(string nome)
        {
            if (this.Nome.Contains(nome) || this.Tema.filtra(nome))
            {
                return true;
            }
            else
            {
                foreach(Artista artista in Artistas)
                {
                    if(artista.filtra(nome))
                    {
                        return true;
                    }
                }
                return false;
            }   
        }
    }
}