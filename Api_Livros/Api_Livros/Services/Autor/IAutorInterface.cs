using Api_Livros.Models;

namespace Api_Livros.Services.Autor
{
    public interface IAutorInterface
    {
        //[4] Criando o métodos que a gente precisa

        /*[4] Método que vai listar todos os autores
           - Task = indicando que esse método será um método assincrono
           - ResponseModel = Tipo de resposta, model criado está em Autor > AutorService
           * O ResponseModel é um tipo genérico(T) agora vamos indicar o tipo
           - List = o ResponseModel o será um List ele vai retornar toda a lista de autores
           - ListarAutores = nome do método */
        Task<ResponseModel<List<AutorModel>>> ListarAutores();

        /*[4] Método que vai buscar um autor especifico 
              - Task = indicando que esse método será um método assincrono
              - ResponseModel = Tipo de resposta, model criado está em Autor > AutorService
              * O ResponseModel é um tipo genérico(T) agora vamos indicar o tipo
              - AutorModel = o tipo do ResponseModel será o AutorModel que retorna
                um autor unico 
              - ListaAutor = nome do método que recebe o id como parametro para achar o autor */
        Task<ResponseModel<AutorModel>> ListarAutor(int idAutor);

        /*[4] Método que busca autor por id do livro 
              ideia do método parecida como o ListarAutores */
        Task<ResponseModel<AutorModel>> ListarAutorPorLivro(int idLivro);
    }
}
