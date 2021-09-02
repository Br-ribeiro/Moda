using System;
using System.Collections.Generic;
using System.Linq;

namespace Moda_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] vetor = EncherOVetor(20); ;

            for(int i = 0; i<vetor.Length; i++)
            {
                Console.Write(vetor[i] + "/");
            }
         
            int moda = CalcularModa(vetor);
            
            Console.WriteLine("\na moda é: " + moda);
            


        }

        public static int CalcularModa(int[] vetorCheio) {

            var contagemValor = new Dictionary<int, int>();

            foreach (var number in vetorCheio)
            {
                if (contagemValor.ContainsKey(number))
                    contagemValor[number]++;
                else
                    contagemValor.Add(number, 1);
            }
            
            
            return contagemValor.OrderBy(v => v.Value).LastOrDefault().Key;
        }


        public static int[] EncherOVetor(int tamanhodoarray)
        {
            int[] vetorcheio = new int[tamanhodoarray];
            Random rnd = new Random();

            for(int i = 0; i < tamanhodoarray; i++){

                vetorcheio[i] = rnd.Next(1,10);
            }

            return vetorcheio;
        }
    }
}
