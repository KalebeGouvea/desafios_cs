using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorFilmesSeries.Models
{
    public class Tema
    {
        public string Nome { get; set; }
        public Tema(string nome)
        {
            this.Nome = nome;
        }
    }
}