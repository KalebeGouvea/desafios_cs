using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorFilmesSeries.Models
{
    public class Artista
    {
        public string Nome { get; set; }
        public Artista(string nome)
        {
            this.Nome = nome;
        }

        public bool filtra(string nome)
        {
            if (this.Nome.Contains(nome))
                return true;
            return false;
        }
    }
}