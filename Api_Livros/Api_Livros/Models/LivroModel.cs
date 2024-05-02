namespace Api_Livros.Models
{
    /*[2] Modelo da tabela no bancod e dados Livro */
    public class LivroModel
    {
        // [2] Propriedades que no caso vão virar colunas das tabelas
        public int Id { get; set; }
        public string TiTulo { get; set; }
        public AutorModel Autor { get; set; }

    }
}
