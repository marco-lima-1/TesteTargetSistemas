using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        try
        {
            // 1) Cálculo da variável SOMA
            Console.WriteLine("1) Resultado da variável SOMA:");
            int INDICE = 13, SOMA = 0, K = 0;
            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            Console.WriteLine(SOMA);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na questão 1: {ex.Message}");
        }

        try
        {
            // 2) Verificação de número na sequência de Fibonacci
            Console.WriteLine("\n2) Verificação de número na sequência de Fibonacci:");
            Console.Write("Informe um número: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (IsFibonacci(num))
                    Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
                else
                    Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na questão 2: {ex.Message}");
        }

        try
        {
            // 3) Processamento do faturamento diário
            Console.WriteLine("\n3) Processamento do faturamento diário:");

            string filePath = "faturamento.json";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Arquivo de faturamento não encontrado. Criando arquivo de exemplo...");

                string jsonExemplo = "[{\"Dia\": 1, \"Valor\": 1500.50}, {\"Dia\": 2, \"Valor\": 1000.00}, {\"Dia\": 3, \"Valor\": 0.00}, {\"Dia\": 4, \"Valor\": 2000.75}, {\"Dia\": 5, \"Valor\": 3000.30}]";

                File.WriteAllText(filePath, jsonExemplo);
                Console.WriteLine("Arquivo faturamento.json criado com valores fictícios.");
            }

            string json = File.ReadAllText(filePath);
            var faturamento = JsonConvert.DeserializeObject<List<Faturamento>>(json)
                .Where(x => x.Valor > 0).ToList();

            if (faturamento.Count == 0)
            {
                Console.WriteLine("Nenhum dado válido encontrado.");
            }
            else
            {
                double media = faturamento.Average(x => x.Valor);
                Console.WriteLine($"Menor faturamento: {faturamento.Min(x => x.Valor)}");
                Console.WriteLine($"Maior faturamento: {faturamento.Max(x => x.Valor)}");
                Console.WriteLine($"Dias acima da média: {faturamento.Count(x => x.Valor > media)}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na questão 3: {ex.Message}");
        }


        try
        {
            // 4) Percentual de faturamento por estado
            Console.WriteLine("\n4) Percentual de faturamento por estado:");
            Dictionary<string, double> estados = new Dictionary<string, double>
            {
                {"SP", 67836.43}, {"RJ", 36678.66}, {"MG", 29229.88},
                {"ES", 27165.48}, {"Outros", 19849.53}
            };
            double total = estados.Values.Sum();
            if (total == 0)
            {
                Console.WriteLine("Erro: faturamento total não pode ser zero.");
            }
            else
            {
                foreach (var estado in estados)
                    Console.WriteLine($"{estado.Key}: {(estado.Value / total * 100):F2}%");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na questão 4: {ex.Message}");
        }

        try
        {
            // 5) Inversão de string
            Console.WriteLine("\n5) Inversão de string:");
            Console.Write("Digite uma palavra: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Erro: A string não pode estar vazia.");
            }
            else
            {
                Console.WriteLine($"Invertida: {ReverseString(input)}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na questão 5: {ex.Message}");
        }
    }

    // Método para verificar se um número pertence à sequência de Fibonacci
    static bool IsFibonacci(int num)
    {
        int a = 0, b = 1;
        while (b < num)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b == num || num == 0;
    }

    // Método para inverter uma string sem usar funções prontas
    static string ReverseString(string str)
    {
        char[] chars = new char[str.Length];
        int j = 0;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            chars[j] = str[i];
            j++;
        }

        return new string(chars);
    }

    // Classe para mapear os dados do faturamento
    class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}
