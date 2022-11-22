using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorFilmesSeries.Models
{
    public class Catalogo
    {
        public List<Filme> Filmes = new List<Filme>();
        public Catalogo adiciona(Filme filme)
        {
            this.Filmes.Add(filme);
            return this;
        }
        public override string ToString()
        {
            string result = "";
            foreach(Filme filme in Filmes)
            {
                result += $"Titulo: {filme.Nome}, Tema: {filme.Tema.Nome}\n";
            }
            return result;
        }
    }
}