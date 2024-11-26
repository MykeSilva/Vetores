using System;
using System.Globalization;

namespace Exercicio_02 {
    internal class Program {
        static void Main(string[] args) {

            int N;
            double[] A;

            N = int.Parse(Console.ReadLine());
            A = new double[N];

            // For para ler
            String[] S = Console.ReadLine().Split(' ');
            for(int i = 0; i < N; i++) {
                A[i] = double.Parse(S[i], CultureInfo.InvariantCulture);
            }

            // Mostrar vetor
            for(int i = 0; i < N; i++) {
                Console.Write(A[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // Mostrar soma
            double soma = 0.0;
            for(int i = 0; i < N; i++) {
                soma = soma + A[i]; 
            }

            double media = soma / N;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            // Os autores sempre prezam pela flexibilidade e a facilidade de entendimento do código
            // dividir o código em várias partes definidas para que fique fácil a manutenção futuramente
        }
    }
}
