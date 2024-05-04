using Api_Livros.Migrations;

namespace Api_Livros.Models
{
    /* [3] Classe que será a estrutura das respostas das REQUISIÇÕES tanto 
           das ROTAS de Autor como Livros e como será desses 2 tipos 
           então o tipo dele tem que ser genéricio<T>           
           
           Dados  = toda as tabelas de dados tanto de autor como de livro
           
           Mensagem = resposta da requisição caso tenha alguma mensagem 
                      caso não tenha vira um campo vazio

           Status = o retorno positivo ou negativo do status
                    caso não tenha por padrão será true
     */
    public class ResponseModel<T> // indicando tipo genérico <T>
    {
        /*[3] Como Dados poderá receber tanto dados do autor como de livros e eles
              são diferentes o tipo tem que ser genérico T e neste caso aceita nulo */
        public T? Dados {get; set;}  
        public string Mensagem { get; set; } = string.Empty; // se inicia vazia
        public bool Status { get; set; } = true; // se inicia true
    }
}
