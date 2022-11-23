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

        public Catalogo filtra(string nome)
        {
            Catalogo novoCatalogo = new Catalogo();
            foreach (Filme filme in Filmes)
            {
                if(filme.filtra(nome))
                    novoCatalogo.adiciona(filme);
            }
            return novoCatalogo;
        }

        public Catalogo uniao(Catalogo catalogoAdicional)
        {
            Catalogo novoCatalogo = new Catalogo();
            foreach (Filme filme in Filmes)
            {
                novoCatalogo.adiciona(filme);
            }
            foreach(Filme filme in catalogoAdicional.Filmes)
            {
                novoCatalogo.adiciona(filme);
            }
            return novoCatalogo;
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