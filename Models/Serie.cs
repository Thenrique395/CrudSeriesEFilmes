using System;

namespace CrudSeriesEFilmes.Models
{
    public class Serie : ClasseBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Status { get; set; }

        public Serie(int id ,Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Status = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero" + Genero + Environment.NewLine;
            retorno += "Titulo" + Titulo + Environment.NewLine;
            retorno += "Descricao" + Descricao + Environment.NewLine;
            retorno += "Status" + Status + Environment.NewLine;
            retorno += "Ano do inicio" + Ano;
            return retorno;
        }
        public int RetornaId()
        {
            return Id;
        }

        public string RetornaTitulo() { 
        return Titulo;
        }

        public bool retornaExcluido()
        {
            return Status;
        }
        public void Excluir() {
            Status = true;  
        }
    }
}
