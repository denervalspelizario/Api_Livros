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
        public async Task<ResponseModel<AutorModel>> ListarAutor(int idAutor)
        {
            //[4] Criando o objeto de resposta tipo AutorModel
            ResponseModel<AutorModel> resposta = new ResponseModel<AutorModel>();
            try
            {
                //[4] atravez do _context pegou os dados da tabela Autores
                var autor = await _context.Autores.FirstOrDefaultAsync(autorBanco => autorBanco.Id == idAutor);

                //[4] validação
                if(autor == null)
                {
                    resposta.Mensagem = "Nenhum registro localizado";
                    return resposta;
                }


                //[4] não deu erro então
                resposta.Dados = autor;
                resposta.Mensagem = "Autor Localizado";

                return resposta;

            }
            catch (Exception erro)
            {
                resposta.Mensagem = erro.Message;
                resposta.Status = false;

                return resposta;
                
            }


        }


        // [4] IMPLEMENTANDO OS METODOS FEITOS NA INTERFACE
        // METODO QUE LISTA TODOS AUTORES
        public async Task<ResponseModel<List<AutorModel>>> ListarAutores()
        {
            //[4] Criando o objeto de resposta que será uma LISTA de AutorModel
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();
            
            try
            {
                //[4] atravez do _context pegou os dados da tabela Autores
                var autores = await _context.Autores.ToListAsync();

                //[4] adicionando a propriedade Dados os autores
                resposta.Dados = autores;
                resposta.Mensagem = "Todos os autores foram coletados";

                //[4] retornando a resposta
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
