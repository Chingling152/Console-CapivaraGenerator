using System;
using System.Text;
using CapivaraGenerator.Capivara_;

namespace CapivaraGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Capivara Generator 2000";
            Console.OutputEncoding = Encoding.UTF8;

            Capivara capivara = new Capivara();

            int contador = 0;
            int tamanho;

            Console.WriteLine("Insira um valor");
            int.TryParse(Console.ReadLine(),out tamanho);   
            tamanho = tamanho <= 0 ? 1 : tamanho;

            while(contador < tamanho+5){               
                if(contador > 5 && contador < tamanho +4){
                    Console.WriteLine(capivara.linha[6]);
                    contador++;
                }else if(contador == tamanho + 4){
                    Console.WriteLine(capivara.linha[7]);
                    contador++;
                }else if(contador < 6){      
                    switch(contador){                       
                        case 4 :                           
                            Console.WriteLine($"{capivara.linha[contador]}---> {capivara.gerarFala()}");
                            break;
                        default:
                            Console.WriteLine($"{capivara.linha[contador]}");
                            break;
                    }  
                    contador ++;        
                }
            }
            Console.ReadKey();
        }
    }
}
