using Classe.Src;
using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LojaRoupa legging = new LojaRoupa(Categoria.FITNESS, "legging", "preta", "inverno");
            LojaRoupa pulseira = new LojaRoupa(Categoria.ACESSORIOS, "pulseira", "dourada", "verão");
            LojaRoupa sandalia = new LojaRoupa(Categoria.CALCADO, "sandália", "prateada", "verão");
            LojaRoupa sutia = new LojaRoupa(Categoria.LINGERIE, "sutiã", "branco", "verão");
            LojaRoupa sunga = new LojaRoupa(Categoria.MODAPRAIA, "sunga", "azul-marinho", "verão");

            Console.WriteLine(legging.ToString());

            Console.WriteLine("\n");

            Console.WriteLine(pulseira.ToString());

            Console.WriteLine("\n");

            Console.WriteLine(sandalia.ToString());

            Console.WriteLine("\n");

            Console.WriteLine(sutia.ToString());

            Console.WriteLine("\n");

            Console.WriteLine(sunga.ToString());

        }
    }
}
