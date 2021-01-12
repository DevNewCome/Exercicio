using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            Console.WriteLine("Programa para calcular o valor dos bicos dos funcionarios");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Para continuar insira o login ");
            string login = Console.ReadLine();
            Console.WriteLine("Digite a senha");
            int senha = int.Parse(Console.ReadLine());

            Funcionario func = new Funcionario();

            if (login == func.Login || senha == func.Senha)
            {



                Console.WriteLine("");
                Console.WriteLine("Login realizedo com sucesso");
                Console.WriteLine("");
                Console.WriteLine("===BEM VINDO AO PROGRAMA TESTE===");
                Console.WriteLine("");

                Console.WriteLine("Numero de funcionários para cadastrar: ");
                int op = int.Parse(Console.ReadLine());
                for (int i = 0; i < op; i++)
                {


                    Console.WriteLine("Digite o nome do funcionario: ");
                    func.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o valor pago");
                    func.Valordia = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o total de dias trabalhados: ");
                    func.Dias = int.Parse(Console.ReadLine());
                    func.Salary(func.Dias);

                }
                Console.WriteLine("Deseja continuar o cadastro ? (S) sim (N) não");
                char opcontinuar = char.Parse(Console.ReadLine());
                if (opcontinuar == 'S' || opcontinuar == 's')
                {
                    for (int i = 0; i < op; i++)
                    {


                        Console.WriteLine("Digite o nome do funcionario: ");
                        func.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o valor pago");
                        func.Valordia = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o total de dias trabalhados: ");
                        func.Dias = int.Parse(Console.ReadLine());
                        func.Salary(func.Dias);
                    } 
                } 
            
               


                Console.WriteLine("O salario final do mês foi de: ");


                Console.WriteLine("------------------------------");
                Console.WriteLine(func);
            }  else
            {
                Console.WriteLine("");
                Console.WriteLine("Senha errada programa encerrado");
            }  Environment.Exit(0);




        }
    }
}
