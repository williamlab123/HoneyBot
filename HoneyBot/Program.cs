using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace mel
{
 
    class Program
    {
 
 
        static void Main(string[] args)
        {
 
            string version = "v1.1.0(beta)";
 
 
             float baldes = 25;
             float garrafinhas = 0.7f;
             float ReaisPropilis = 0;
             float ReaisGarrafihas = 0;
             float ReaisBalde = 0;
             float lucros = 0;
 
 
             char  escolha;
 
            // string Validos = "a, b, c, d, e, f, g, sair";
            //char[] caracteresValidos = Validos.ToCharArray();
 
 
 
 
            inicio:
 
            Console.Clear();
 
            Console.ForegroundColor = ConsoleColor.Cyan;
 
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                         HoneyBot");
            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("________________________________________________________________________________________________________________________");
 
 
            Console.ResetColor();
 
            Console.WriteLine("");
            Console.WriteLine("");
 
 
 
 
 
 
            Console.WriteLine("Bem vindo ao HoneyBot");
            Console.WriteLine(version);
            Console.WriteLine("");
 
 
 
 
 
            Console.WriteLine("Digite a para converter baldes de mel em garrafinhas");      
            Console.WriteLine("Digite b para calcular em reais os baldes de mel");
            Console.WriteLine("Digite c para converter garrafinhas de mel em reais");
            Console.WriteLine("Digite d para converter em reais vidrinhos de propilis");
            Console.WriteLine("Digite e para ver os lucros do dia");
            Console.WriteLine("Digite f para ver o estoque");
            Console.WriteLine("Digite g para abrir o formulário");
            Console.WriteLine("Digite h para caixa de abelha");
 
 
            Console.WriteLine("Digite s para fechar o programa");
 
 
 
 
            escolha = char.Parse(Console.ReadLine());
 
 
 
 
            bool isTyping = false;
 
 
 
 
            if (escolha == 'a')
            {
 
                isTyping = true;
 
                Console.WriteLine("digite a quantidade de baldes de mel");
                int QuantidadeBaldes = int.Parse(Console.ReadLine());
 
 
                float TotalBaldes = QuantidadeBaldes * baldes;
 
                float TotalGarrafinhas = TotalBaldes / garrafinhas;
 
                Console.WriteLine(TotalGarrafinhas + " garrafinhas");
 
 
 
 
            }
 
            if (escolha == 'b') 
            {
 
 
                isTyping = true;
 
 
                Console.WriteLine("digite o preço do balde");
                float PrecoBalde = float.Parse(Console.ReadLine());
 
                Console.WriteLine("digite a quantidade de baldes a ser calculado");
 
                float Baldes = float.Parse(Console.ReadLine());
                  ReaisBalde = Baldes * PrecoBalde;
                Console.WriteLine(ReaisBalde + " reais");
 
 
                string filePath = @"C:\openner\estoque.txt";
 
 
 
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();
 
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
 
                lines.Add($"lucros em baldes: {ReaisBalde}");
                lines.Add(DateTime.Now.ToString());
                lines.Add("");
                File.WriteAllLines(filePath, lines);
 
 
            }
 
 
            if (escolha == 'c') 
            {
 
                isTyping = true;
 
 
                int PrecoGarrafinha = 17;
 
                Console.WriteLine("digite a quantidade de garrafinhas a ser calculada");
 
                int QuantidadeGarrafinhas = int.Parse(Console.ReadLine());
 
                  ReaisGarrafihas = PrecoGarrafinha * QuantidadeGarrafinhas;
 
                Console.WriteLine(ReaisGarrafihas + " reais");
 
 
                string filePath = @"C:\openner\estoque.txt";
 
 
 
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();
 
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
 
                lines.Add($"lucros em garrafinhas: {ReaisGarrafihas}");
                lines.Add(DateTime.Now.ToString());
                lines.Add("");
                File.WriteAllLines(filePath, lines);
 
 
            }
 
            if (escolha == 'd')  
            {
 
                isTyping = true;
 
                int PrecoPropilis = 20;
 
                Console.WriteLine("digite a quantidade de vidrinhos de propílis");
 
                int QuantidadePropilis = int.Parse(Console.ReadLine());
 
                   ReaisPropilis = PrecoPropilis * QuantidadePropilis;
 
                Console.WriteLine(ReaisPropilis);
 
 
                string filePath = @"C:\openner\estoque.txt";
 
 
 
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();
 
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
 
                lines.Add($"lucros em propílis: {ReaisPropilis}");
                lines.Add(DateTime.Now.ToString());
                lines.Add("");
                File.WriteAllLines(filePath, lines);
 
 
 
            }
 
            if (escolha == 'e') //calcular lucros do dia 
            {
 
                isTyping = true;
 
                lucros = ReaisPropilis + ReaisGarrafihas + ReaisBalde;
                Console.WriteLine(  lucros + " reais");
 
 
 
                string filePath = @"C:\openner\estoque.txt";
 
 
 
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();
 
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
 
                lines.Add($"lucros do dia: {lucros}");
                lines.Add(DateTime.Now.ToString());
                lines.Add("");
                File.WriteAllLines(filePath, lines);
 
 
 
 
            }
 
 
             if ( escolha == 'f') 
            {
 
                isTyping = true;
 
                Console.WriteLine("Digite a quantidade de  baldes de mel ");
                Console.WriteLine("Digite a quantidade de garrafinhas");
                Console.WriteLine("Digite a quantidade de vidrinhos de propílis");
 
                int estoque = int.Parse(Console.ReadLine());
                int estoque1 = int.Parse(Console.ReadLine());
                int estoque2 = int.Parse(Console.ReadLine());
 
 
 
 
                string filePath = @"C:\openner\estoque.txt";
 
 
 
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();
 
 
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
 
                }
 
                lines.Add($"estoque de baldes de mel:  {estoque}");
                lines.Add($"estoque de garraginhas:  {estoque1}");
                lines.Add($"estoque de vidrinhos de propílis: {estoque2}");
 
                lines.Add(DateTime.Now.ToString());
                lines.Add("");
                File.WriteAllLines(filePath, lines);
 
 
                if (estoque < 10)
                {
                    Console.WriteLine($"estoque de baldes de mel muito baixo: {estoque}");
                    lines.Add("");
                }
 
 
 
 
            }
 
 
 
             if (escolha == 'h') 
            {
                Console.Clear();
 
                isTyping = true;
 
                int caixas = 0;
 
                Console.WriteLine("Adicionar caixas de abelha e quadrinhos[1]");
                Console.WriteLine("Calcular a quantidade de mel total de todas as caixas[2]");
                Console.WriteLine("Calcular o valor em reais$ de todas as caixas[3]");
 
                int escNum = int.Parse(Console.ReadLine());
 
                Console.Clear();
 
                if(escNum == 1) 
                {
                    Console.WriteLine("Em que lugar?");
 
                    string lugarCaixas = Console.ReadLine();
 
                    Console.WriteLine("Quantidade de caixas a serem adicionadas:");
                    caixas = int.Parse(Console.ReadLine());
 
                    string filePath = @"C:\openner\estoque.txt";
 
 
 
                    List<string> lines = new List<string>();
                    lines = File.ReadAllLines(filePath).ToList();
 
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
 
                    lines.Add($"Caixas de abelha: {caixas}, {lugarCaixas}");
                 ;
                    lines.Add(DateTime.Now.ToString());
                    lines.Add("");
                    File.WriteAllLines(filePath, lines);
                }
 
                if(escNum == 2) 
                {
                    Console.Clear();
 
                    Console.WriteLine("Quantas caixas?");
 
                    caixas = int.Parse(Console.ReadLine());
 
                    Console.WriteLine("Quantos meses as caixas ficaram trabalhando?");
 
                    int meses = int.Parse(Console.ReadLine());
 
 
                    var melCaixas = caixas * 3.75 * meses;
 
                    Console.WriteLine($"{melCaixas} kilos de mel");
 
 
                }
 
 
                if(escNum == 3) 
                {
                    Console.WriteLine("Quantas caixas ao total?");
 
                    int QntCaixas = int.Parse(Console.ReadLine());
 
                    int precoCaixa = QntCaixas * 300;
 
                    Console.WriteLine(precoCaixa);
                }
 
 
 
 
 
 
            }
 
 
            if (escolha == 'g') 
            {
 
                isTyping = true;
 
                System.Diagnostics.Process.Start("notepad.exe", @"C:\openner\estoque.txt");
 
 
 
 
            }
 
 
 
 
            if (escolha == 's')
             {
 
                isTyping = true;
 
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pressione ENTER");
                Console.ResetColor();
                Environment.Exit(0);
 
 
 
 
             }
 
 
            if (isTyping == false) 
            {
                Console.WriteLine("Por favor, digite uma opçao válida");
            }
 
 
            else 
            {
 
 
            }
 
 
 
 
 
 
 

 
 
 
 
 
        }
 
 
 
 
 
 
 
 
 
 
 
    }
}
 
