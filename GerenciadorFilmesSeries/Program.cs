using System;
using GerenciadorFilmesSeries.Models;

namespace GerenciadorFilmesSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Main disponibilizado pelo enunciado do problema
            Filme mp = new Filme("Medida Provisoria", new Tema("Ficcao"));
            Filme cd = new Filme("Cidade de Deus", new Tema("Drama"));
            Filme ac = new Filme("Auto da Compadecida", new Tema("Aventura"));
            Serie ir = new Serie("Irmandade", new Tema("Drama"), 1, 1, "O Certo e o Certo");
            Artista tais = new Artista("Tais Araujo");
            Artista jorge = new Artista("Seu Jorge");
            Artista selton = new Artista("Selton Mello");
            mp.adicionaArtista(tais);
            mp.adicionaArtista(jorge);
            ac.adicionaArtista(selton);
            cd.adicionaArtista(jorge);
            ir.adicionaArtista(jorge);
            Catalogo catalogo = new Catalogo();
            catalogo.adiciona(mp).adiciona(cd).adiciona(ac).adiciona(ir);
            Console.WriteLine("Catalogo completo:");
            Console.WriteLine(catalogo);
            //Console.WriteLine("Filmes e Series com Seu Jorge:");
            //Console.WriteLine(catalogo.filtra("Jorge"));
            //Console.WriteLine("Dramas:");
            //Console.WriteLine(catalogo.filtra("Drama"));
            //Console.WriteLine("Filmes e Series com Tais Araujo e Selton Mello juntos:");
            //Console.WriteLine(catalogo.filtra("Tais").filtra("Mello"));
            //Console.WriteLine("Filmes e Series com Tais Araujo unidos com os do Selton Mello:");
            //Console.WriteLine(catalogo.filtra("Tais").uniao(catalogo.filtra("Mello")));
        }
    }
}