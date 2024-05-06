using Api_Livros.Models;
using Api_Livros.Services.Autor;
using Microsoft.AspNetCore.Mvc;

namespace Api_Livros.Controllers
{
    /* [4] A LINHA DE RECIOCIONIO  É CONTROLLER(AutorControle) SE COMUNICA COM A 
           INTERFACE(IAutorInterface) QUE SE COMUNICA COM O SERVICE(AutorService)*/
    public class AutorController : Controller
    {
        // [4] Propriedade _autorInterface recebe métodos IAutorInterface
        private readonly IAutorInterface _autorInterface;

        //[4] Construtor Necessario para pegar a _autorInterface
        public AutorController(IAutorInterface autorInterface) 
        {
            _autorInterface = autorInterface;
        }


        //[4] Get que lista autores
        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()
        {   /*- Task = indicando método assincrono
              - ActionResult = tipo de msg e status
              - ResponseModel = Tipo da resposta, model criado está em Autor > AutorService
              OBS: O ResponseModel é um tipo genérico(T) agora vamos indicar o tipo
              - List = a resposta sera uma LISTA
              - AutorModel = essa LISTA sérá de autores no formato de AutorModel */

            //[4] pegando de modo assincrono o metodo ListarAutores e jogando em autores 
            var autores = await _autorInterface.ListarAutores(); 

            //[4] retornando os autores
            return Ok(autores);

        }

        //[4] Get buscado autor por Id
        [HttpGet("ListandoAutorPorId/{idAutor}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> ListarAutorPorId(int idAutor)
        {   /*- Task = indicando método assincrono
              - ActionResult = tipo de msg e status
              - ResponseModel = Tipo da resposta, model criado está em Autor > AutorService
              OBS: O ResponseModel é um tipo genérico(T) agora vamos indicar o tipo
              - AutorModel = essa LISTA sérá de autores no formato de AutorModel */

            // [4] pegando em modo assincrono o metodo ListarAutor e ja passando o id
            var autor = await _autorInterface.ListarAutor(idAutor);

            //[4] retornando o autor
            return Ok(autor);

        }


    }
}
