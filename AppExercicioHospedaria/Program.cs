using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioHospedaria
{
    internal class Program
    {

        static void hospedaria()
        {
            Console.WriteLine("Qual o valor individual da diária?");
            double valor_diaria = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos adultos vão se hospedar?");
            int numero_adultos = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas crianças vão se hospedar?");
            int numero_criancas = int.Parse(Console.ReadLine());

            double valor_total_diaria = valor_diaria * numero_adultos + numero_criancas * valor_diaria / 2;
            Console.WriteLine($"O valor total em uma diária é de {valor_total_diaria.ToString("C")}");

            Console.WriteLine("Por quantos dias a família ficará hospedada?");
            int numero_diarias = int.Parse(Console.ReadLine());

            double valor_total = valor_total_diaria * numero_diarias;

            Console.WriteLine($"O valor total da estadia é de R${valor_total}. Pretende parcelar em quantas vezes? \n(Parcelado em até 4 vezes, temos 10% de desconto)");
            int numero_parcelas = int.Parse(Console.ReadLine());

            if (numero_parcelas <= 4)
            {
                valor_total = valor_total * 0.9;
                Console.WriteLine("Com 10% de desconto...");
            }

            Console.WriteLine($"Em {numero_parcelas} parcelas, o valor por parcela será de R${valor_total / numero_parcelas}");

        }

        static void faturamento_lucro()
        {
            Console.Write("Informe o número de peças: ");
            int numero_pecas = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de venda unitário: ");
            double valor_venda = double.Parse(Console.ReadLine());

            double faturamento = numero_pecas * valor_venda;
            Console.Write($"O faturamento é de {faturamento.ToString("C")}\n");

            Console.Write("Informe o valor de compra unitária: ");
            double valor_compra = double.Parse(Console.ReadLine());

            Console.Write("\nInsira o valor de despesas fixas");
            double despesas_fixas = double.Parse(Console.ReadLine());

            double custo_total = numero_pecas * valor_compra + despesas_fixas;

            Console.Write($"O custo total é de {custo_total.ToString("C")}\n");

            double lucro = faturamento - custo_total;

            Console.Write($"O lucro da empresa é de {lucro.ToString("C")}");
        }

        static void exercicio_porcentagem()
        {
            Console.Write("Informe seu salário: ");
            double salario_bruto = double.Parse(Console.ReadLine());

            Console.Write("Informe o percentual de desconto (%): ");
            double percentual = double.Parse(Console.ReadLine());

            double salario_liquido = salario_bruto * (1 - percentual / 100);

            Console.WriteLine($"Seu salário líquido é de {salario_liquido.ToString("C")}");

        }


        static void Main(string[] args)
        {
            //faturamento_lucro();
            exercicio_porcentagem();
            Console.ReadLine();
        }
    }
}
