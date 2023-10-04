namespace Excecoes;

class Program
{
    static void Main(string[] args)
    {

        //Cadastrar("");

        var array = new int[3];

        //TRY & CATCH

        /* 
         - Pode se adicionar mais de 1 catch para um Try.
         - Pode se especificar o catch para excecao desejada.
         - Listar os catchs do mais específico para o mais genérico em casacata.
        */

        try
        {
            for (int i = 0; i < array.Length + 1; i++)
            {
                // System.IndexOutOfRangeException = Tipo de Exceção
                Console.WriteLine(array[i]);
            }
        }
        //Passando o "ex", obtemos mais infos sobre as ex
        catch (MinhaException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.QuandoAconteceu);
            Console.WriteLine("Exceção Personalizada");
        }

        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Não encontrei o index na lista");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Ops, algo deu errado :/ ...");
        }

        //FINALLY, sempre passa nesse final

        finally { Console.WriteLine("Chegou ao fim!"); }

        //Disparando Exceções

        static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto)) ;
            {
                //Pode ser colocados tipos diferentes de Exceção no "throw"                
                /*
                  Ex: 
                 
                  throw new  ArgumentNullExeption("O Texto não pode ser nulo ou vazio"); 
                
                 */

                throw new Exception("O Texto não pode ser nulo ou vazio");
            }
        }
    }

    //Exceções Personalizadas
    public class MinhaException : Exception
    {
        public MinhaException(DateTime date)
        {
            QuandoAconteceu = date;
        }

        public DateTime QuandoAconteceu { get; set; }
    }
}

