using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Sete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite em qual ano voce nasceu");
                var nome = Console.ReadLine();

                Console.WriteLine("Informe a data de nascimento / dd/mm/yyyy");
                //DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);
                var dataNascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine(ObterMensagemFaixaEtaria(nome, dataNascimento));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }

        }
        private static string ObterMensagemFaixaEtaria(string nome, DateTime dataNascimento)
        {
            var idade = DateTime.Today.Year - dataNascimento.Year;

            if (idade >= 60)
                return $"Olá {nome}, está na faixa etária idoso!";
            else if (idade >= 20 && idade <= 59)
                return $"Olá {nome}, está na faixa etária Adulto!";
            return $"Olá {nome}, está na faixa etária Jovem!";
        }
      }
}
