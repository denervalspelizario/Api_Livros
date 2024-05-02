using Api_Livros.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Livros.Data
{
    /* [2] Contexto para banco de dados  que herda  metodos da classe DbContext do EntityFrameworkCore */
    public class AppDbContext : DbContext 
    {
        //[2] Construtor que recebe algumas opções de conexões(DbContextOptions)
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        
        
        //[2] Tabelas que serão criadas 
         
        //[2] AutorModel = a forma, a estrutura da tabela * Autores = nome da tabela
        public DbSet<AutorModel> Autores { get; set; }

        //[2] LivroModel = a forma, a estrutura da tabela * Livros = nome da tabela
        public DbSet<LivroModel> Livros { get; set; }

    }
}
