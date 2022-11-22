using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorFilmesSeries.Models
{
    public class Catalogo
    {
        public List<Filme> Filmes { get; set; }
        public Catalogo adiciona(Filme filme)
        {
            this.Filmes.Add(filme);
            return this;
        }
    }
}