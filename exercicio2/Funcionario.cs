using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio2
{
    class Funcionario
    {
        public int Dias;
        public string Nome;
        public double Valordia;
        public string Login =  "jefferson";
        public int Senha = 123;
        public double Salariofinal;
        

        public Funcionario()
        {
        }

        public Funcionario(string nome, int dias, double valordia, double salariofinal)
        {
            Nome = nome;
            Dias = dias;
            Valordia = valordia;
            Salariofinal = salariofinal;
        }


      
        public void Salary(double dias) 
        {
            Salariofinal = Salariofinal +  Valordia * dias;
             
        }

       

        public override string ToString()
        {
            return Nome + ", " + Dias + " Dias Trabalhados, " + " Salario" + " $" + Salariofinal;
        }

    }
}
