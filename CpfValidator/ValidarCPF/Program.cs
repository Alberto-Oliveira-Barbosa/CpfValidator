using System;

namespace ValidarCPF
{
    class Program
    {

        public static bool valida(String cpf){
            int[] numeros = new int [11];
            
            //popula o array de numeros, já convertendo para tipo numérico
            for (int i = 0; i < 11; i++)
            {
                numeros[i] = Convert.ToInt16(cpf.Substring(i,1));
            }

            if(numeros[0] == numeros[1] && numeros[1] == numeros[2] && numeros[2] == numeros[3] && numeros[3] == numeros[4] && numeros[4] == numeros[5] && numeros[5] == numeros[6] && numeros[6] == numeros[7] && numeros[7] == numeros[8] && numeros[8] == numeros[9] && numeros[9] == numeros[10]){
                return false;
            
            } else{
                
                int somaDigito1 = 0;
                int j =10;
                for (int i = 0 ; i < 9; i++)
                {
                    somaDigito1 +=  numeros[i] * j;
                    j--; 
                }
                
                double resto1 = calculaResto(somaDigito1);


                int somaDigito2 = 0;
                j=11;
                for (int i = 0; i < 10; i++)
                {
                    somaDigito2 += numeros[i] * j;
                    j--;
                }
                double resto2 = calculaResto(somaDigito2);

                if(numeros[9] == resto1 && numeros[10] == resto2) return true;
                else return false;  

            }
 
        }

        public static double calculaResto(double NumeroCPF){
            double resto = (NumeroCPF * 10) % 11;
            if(resto == 10) resto = 0;
            return resto;
        }

        static void Main(string[] args)
        {
            //int[] res = valida(Console.ReadLine());
            Console.WriteLine("-----------Validador de CPF-----------\n\n");
            Console.WriteLine("Digite o número do CPF sem pontos e vírgulas");
            String cpf = Console.ReadLine();
            if(valida(cpf)){
                Console.WriteLine("CPF Válido");
            } else{
                Console.WriteLine("CPF inválido!");
            }

        }
    }
}
