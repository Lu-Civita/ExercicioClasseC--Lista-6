using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe.Src
{
    public class LojaRoupa
    {
        Categoria Tipo { get; set; }
        string Nome { get; set; }
        string Cor { get; set; }
        string Estacao { get; set; }

        public LojaRoupa(Categoria tipo, string nome, string cor, string estacao)
        {
            Tipo = tipo;
            Nome = nome;
            Cor = cor;
            Estacao = estacao;
        }

        public override string ToString()
        {
            return
                $"\n Nome da Peça de roupa: {Nome}" +
                $"\n Tipo da Peça de roupa: {Tipo}" +
                $"\n Cor da Peça de roupa: {Cor}" +
                $"\n Estação da Peça de roupa: {Estacao}";
        }

    }

    public enum Categoria
    {
        FITNESS,
        ACESSORIOS,
        CALCADO,
        LINGERIE,
        MODAPRAIA,
    }
}
