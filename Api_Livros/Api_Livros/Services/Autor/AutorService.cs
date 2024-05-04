using Api_Livros.Data;
using Api_Livros.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Livros.Services.Autor
{
    // [3] Referenciando IAutorInterface a AutorSErvice
    public class AutorService : IAutorInterface
    {
        // [4] RECEBENDO O CONTEXT DO BD
        private readonly AppDbContext _context;
        public AutorService(AppDbContext context) 
        {
            _context = context;
        }
         

        // [4] IMPLEMENTANDO OS METODOS FEITOS NA INTERFACE
        public Task<ResponseModel<AutorModel>> ListarAutor(int idAutor)
        {
            throw new NotImplementedException();
        }

        // [4] IMPLEMENTANDO OS METODOS FEITOS NA INTERFACE
        // METODO QUE LISTA TODOS AUTORES
        public async Task<ResponseModel<List<AutorModel>>> ListarAutores()
        {
            // Criando o objeto de resposta
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();
            
            try
            {
                // atravez do _context pegou os dados da tabela Autores
                var autores = await _context.Autores.ToListAsync();

                // adicionando a propriedade Dados os autores
                resposta.Dados = autores;
                resposta.Mensagem = "Todos os autores foram coletados";

                // retornando a resposta
                return resposta;
            }
            catch (Exception erro)
            {
                resposta.Mensagem = erro.Message; 

                resposta.Status = false; // como deu erro status será false(ele por default e true)

                return resposta;
            }
        }

        // [4] IMPLEMENTANDO OS METODOS FEITOS NA INTERFACE
        public Task<ResponseModel<AutorModel>> ListarAutorPorLivro(int idLivro)
        {
            throw new NotImplementedException();
        }
    }
}
