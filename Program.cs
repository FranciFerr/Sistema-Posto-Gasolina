using System;

/*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
exemplo.
*/

namespace pesquisa_posto_gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" __________________________________________");
            Console.WriteLine("|                 PESQUISA                 |");
            Console.WriteLine("|__________________________________________| ");
            Console.WriteLine("|  QUAL O COMBUSTÍVEL DE SUA PREFERÊNCIA ? |");
            Console.WriteLine("|__________________________________________|");
            Console.WriteLine("|               1 . ÁLCOOL                 |");
            Console.WriteLine("|__________________________________________|");
            Console.WriteLine("|               2 . GASOLINA               |");
            Console.WriteLine("|__________________________________________|");
            Console.WriteLine("|               3 . DIESEL                 |");
            Console.WriteLine("|__________________________________________|");
            Console.WriteLine("|               4 . FIM                    |");
            Console.WriteLine("|__________________________________________|");
            Console.WriteLine("");
            Console.WriteLine(" DIGITE O CÓDIGO DO COMBUSTIVEL DE SUA PREFERÊNCIA :  ");
            

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4){
                if(tipo == 1)
                { 
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if(tipo == 3)
                {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());

            }


            Console.WriteLine(" MUITO OBRIGADO!!! ");
            Console.WriteLine(" ALCOOL = " + alcool);
            Console.WriteLine(" GASOLINA = " + gasolina);
            Console.WriteLine(" DIESEL = " + diesel);


        }
    }
}
