using System.Text.Json.Serialization;

namespace Api_Livros.Models
{
    /*[2] Modelo da tabela no bancod e dados Autor*/
    public class AutorModel
    {
        // [2] Propriedades que no caso vão virar colunas das tabelas
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /*[2] essa coluna tera uma coleção de LivroModel( Id, Titulo e Autor) */
        [JsonIgnore]  //[2] não sera mostrada no json de requisição
        public ICollection<LivroModel> Livros { get; set; }

    }
}
