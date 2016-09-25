using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MusicalChallenge.Models
{

    //Uso da Entity Framework e Code First para criar as colunas da nossa tabela de dados 

    public class Media                
    {
        public int ID { get; set; }    //Chave primaria
        public int Codigo { get; set; }   //Codigo do produto
        public string Titulo { get; set; }   
        public string Categoria { get; set; }    //Livro/cd/dvd

        public int  Data { get; set; }   //ano
        public string Descricao { get; set; }       //genero musical ou televisivo
        public string Autoria { get; set; }
    }

    public class MediaDBContext : DbContext          //Classe da EF que definira o contexto da nossa classe media
    {
        public DbSet<Media> Medias { get; set; }
    }




}