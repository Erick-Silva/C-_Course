using Csharp.Classes;
using System.Globalization;

namespace Csharp
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo x: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();
                     
            Console.WriteLine($"Área de x = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");
            if (areaX > areaY)
            {
                Console.WriteLine("Área de do triangulo X, maior que a área do triangulo Y.");
            }
            else
            {
                Console.WriteLine("Área de do triangulo Y, maior que a área do triangulo X.");
            }
            */

            /*
            Pessoas Pessoa1 = new Pessoas();
            Pessoas Pessoa2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            Pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            Pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Pessoa2.idade = int.Parse(Console.ReadLine());

            if (Pessoa1.idade > Pessoa2.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {Pessoa1.Nome}");
            }
            else if (Pessoa1.idade < Pessoa2.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {Pessoa2.Nome}");
            }
            else
            {
                Console.WriteLine($"{Pessoa1.Nome} e {Pessoa2.Nome}, possuem a mesma idade.");
            }
            */

            /*
            Funcionarios Funcionario1 = new Funcionarios();
            Funcionarios Funcionario2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            Funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            Funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (Funcionario1.Salario + Funcionario2.Salario) / 2;

            Console.WriteLine($"Salário médio: {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            /*
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nDigite o numero de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nDados atualizados: " + p);

            Console.Write("\nDigite o numero de produtos a ser removidos do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nDados atualizados: " + p);
            */

            /*
            //Exercicio 1 - Classes, Atributos e Métodos
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area: {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro: {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal: {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
            */

            /*
            //Exercício 2 - Classes, atributos e métodos
            Funcionarios funcionario = new Funcionarios();


            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + funcionario);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine("Funcionário: " + funcionario);

            */

            /*
             
            //Exercício 3 - Classes, atributos e métodos


            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"NOTA FINAL: {aluno.NotaFinal()}");
            aluno.Aprovacao(aluno.NotaFinal());

            */

            /*
            
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Circ = Calculadora.Circunferencia(raio);
            double Vol = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferencia: {Circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Vol.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pi: {Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture)}");

            */

            /*
            Console.Write("Qual é a cotação do dolar? ");
            double Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.ValorEmReais(Quantidade, Cotacao);

            Console.WriteLine($"Valor a ser pago em reais = {total.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            /*      
            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Produto p = new Produto(nome, preco);

            Produto p3 = new Produto {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 5
            };

            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nDigite o numero de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nDados atualizados: " + p);

            Console.Write("\nDigite o numero de produtos a ser removidos do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nDados atualizados: " + p);
            */

            /*
            Produto p = new Produto("TV", 500, 10);
                                    
            Console.WriteLine(p.Nome);
            */

            /*
            ContaBancaria conta;


            Console.Write("Entre com o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char deposito = char.Parse(Console.ReadLine());

            if (deposito == 's' || deposito == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(num, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(num, nome);
            }

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta);

            Console.Write("\nEntre com um valor para depósito: ");
            double alterarSaldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.AdicionarSaldo(alterarSaldo);
            Console.WriteLine(conta);

            Console.Write("\nEntre com um valor para saque: ");
            alterarSaldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.SaqueSaldo(alterarSaldo);
            Console.WriteLine(conta);
            */

            /*
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            Point pw = new Point();
            Console.WriteLine(pw);
            */

            //double? x = null;


            /*
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }
            */

            /*Operador de coalescencia nula (??) retorna o valor a esquerda do operador, caso não seja nulo
            e retorna o valor a direita do operador, caso o valor a esquerda seja nulo.
            ex: 

            double y = x ?? 0.0;

            Console.WriteLine(y);
            */

            /*
            Problema de armazenamento de objetos do tipo struct num vetor 
             
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n ;
            Console.WriteLine($"Average Height: {avg.ToString("F2", CultureInfo.InvariantCulture)}");
            */


            /*
            Armazenamento de vetores que contem objetos do tipo referencia.
            cria-se o vetor, e depois instancia-se o objeto. Conforme exemplo.
           
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();   
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine($"Average Price: {avg.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            /*
            Aluguel[] alugueis = new Aluguel[10];

            Console.Write("Quantos quartos serão alugados? ");
            int numeroAlugueis = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroAlugueis; i++)
            {
                Console.WriteLine($"\nAluguel #{i + 1}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                alugueis[numeroQuarto] = new Aluguel { Name = name, Email = email };
            }

            Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < alugueis.Length; i++)
            {
                if ((alugueis[i] != null))
                {
                    Console.WriteLine($"{i}: {alugueis[i].Name}, {alugueis[i].Email}");
                }
            }
            */

            /*
            O que fizemos aqui, basicamente, foi usar um metodo estático que usa o comando PARAMS
            para que o método aceita um número variável de parâmetros na hora de sua implementação.

            Console.WriteLine(Calculator.Sum(2, 3));
            Console.WriteLine(Calculator.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)); 
            */


            //Code smells (design ruim - não utilizar)

            //Ref
            /*
            Modificador ref, utilizado tanto na construção do metodo da classe Calculator, quanto na chamada 
            do programa principal força a criação da referencia da variável a, apontando para a variavel local, 
            utilizada no metodo. Dessa forma, quando o metodo finaliza sua execução, o resultado, da variavel x,
            é atribuido a variável a, pois a variável a aponta para variável x.
            O termo ref, exige que a variável seja iniciada.

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            */

            //Out
            /*
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
            */

            //Boxing - Converter objetos tipo valor, para objetos do tipo referencia compativel.
            /*
            int x = 20;
            Object obj = x;
            

            //Unboxing - Converter objetos do tipo referencia, para objetos do tipo valor compativel.
            int y = (int)obj;
            */

            //Laco for each

            /*  Percorre cada elemento de um vetor, utilizando uma outra sintaxe
            
            string[] vect = new string[] { "Erick", "Paula", "Maria" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
            */

            //Listas
            /*
            List<string> list = new List<string>();
            list.Add("1");
            list.Remove("1");
            */

            //Matrizes
            /*
            double[,] matrix = new double[1,3];
            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix.Rank);
            Console.WriteLine("N° de linhas: " + matrix.GetLength(0));
            Console.WriteLine("N° de colunas: " + matrix.GetLength(1));

            */

            /*
            int dim = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dim, dim];

            for (int i = 0; i < dim; i++)
            {
                string[] StringSeparator = Console.ReadLine().Split(' ');
                for (int j = 0; j < dim ; j++)
                {
                    
                    matrix[i, j] = int.Parse(StringSeparator[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine($"{matrix[i,i]} ");
            }

            int NegativeCounter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] < 0 )
                    {
                        NegativeCounter++;
                    }
                }
            }

            Console.WriteLine($"\nNegative numbers: {NegativeCounter}");
            */
            /*
            string[] dim = Console.ReadLine().Split(' ');
            
            int n = int.Parse(dim[0]);
            int m = int.Parse(dim[1]);

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] StringSeparator = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(StringSeparator[j]);
                }

            }

            int NumberToVerify = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] ==  NumberToVerify)
                    {
                        
                        Console.WriteLine($"Position: {i},{j}:");
                        if ( (j-1) >= 0)
                        {
                            Console.WriteLine($"Left: {matrix[i, (j - 1)]}");
                        }
                        if ( (j+1) < m)
                        {
                            Console.WriteLine($"Right: {matrix[i, (j + 1)]}");
                        }
                        if ( (i-1) >= 0)
                        {
                            Console.WriteLine($"Up: {matrix[(i - 1), j]}");
                        }
                        if ( (i+1) < n)
                        {
                            Console.WriteLine($"Down: {matrix[(i + 1), j]}");
                        }
                         
                    }
                }
            }
            
            */

            /* Switch Case
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Sunday";        
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine($"Day: {day}");
            */

            /*Operador Ternário
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine($"Desconto: R${(double)desconto}");
            */

            /* Métodos úteis para Strings
            string original = "abcde FGHIJ ABC abc DEFG";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);



            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"To Upper: -{s1} -");
            Console.WriteLine($"To Lower: -{s2}-");
            Console.WriteLine($"Trim: - {s3} -");
            Console.WriteLine($"IndexOf('bc'): -{n1}-");
            Console.WriteLine($"LastIndexOf('bc'): -{n2}-");
            Console.WriteLine($"Substring(3): -{s4}-");
            Console.WriteLine($"Substring(3, 5): -{s5}-");
            Console.WriteLine($"Replace('a', 'x'): -{s6}-");
            Console.WriteLine($"Replace('abc', 'xy'): -{s7}-");
            Console.WriteLine($"IsNullOrEmpty: {b1}");
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");

            */




            /* Representação de instante
             * Quantos Ticks passaram desde o dia 1/1 da era atual
            DateTime d2 = new DateTime(2022, 06, 17);
            DateTime d3 = new DateTime(2022, 06, 17, 23, 59, 59);
            DateTime d4 = new DateTime(2022, 06, 17, 23, 59, 59, 58);
            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow;
            DateTime d9 = DateTime.Parse("2000-08-15");
            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            */

            /*
            Contagem de ticks entre dois instantes
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 30);
            TimeSpan t4 = TimeSpan.FromDays(1.5);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

            */

            /*
            int TAMANHO = 10;

            int[] numeros = new int[TAMANHO];
            int aux, i, contador;



            Console.WriteLine("Insira 10 numeros aleatorios, e pressione enter: ");

            for (i = 0; i < TAMANHO; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (contador = 1; contador < TAMANHO; contador++)
            {
                for (i = 0; i < (TAMANHO-1); i++)
                {
                    if (numeros[i] > numeros[i + 1])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[i+1];
                        numeros[i + 1] = aux;
                    }
                }
            }

            Console.WriteLine("Os 10 números em ordem crescente: ");
            for (i = 0; i < (TAMANHO-1) ; i++)
            {
                Console.Write($"{numeros[i].ToString("F2")} ");
            }

            Console.WriteLine("10");

            */

            /*
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 57, 275);
          
            Console.WriteLine(d);
            Console.WriteLine($"1) Date: {d.Date}");
            Console.WriteLine($"2) Day: {d.Day}");
            Console.WriteLine($"3) DayOfWeek: {d.DayOfWeek}");
            Console.WriteLine($"4) DayOfYear: {d.DayOfYear}");
            Console.WriteLine($"5) Hour: {d.Hour}");
            Console.WriteLine($"6) Kind: {d.Kind}");
            Console.WriteLine($"7) Millisecond: {d.Millisecond}");
            Console.WriteLine($"8) Minute: {d.Minute}");
            Console.WriteLine($"9) Month: {d.Month}");
            Console.WriteLine($"10) Second: {d.Second}");
            Console.WriteLine($"11) Ticks: {d.Ticks}");
            Console.WriteLine($"12) TimeOfDay: {d.TimeOfDay}");
            Console.WriteLine($"13) Year: {d.Year}");
            */

            /*
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 57, 275);
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();

            string s5 = d.ToString();

            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss:ff");


            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            */

            /*
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime d2 = d.AddHours(2);

            DateTime d3 = d.AddMinutes(3);

            DateTime d4 = DateTime.Now;
            DateTime d5 = d4.AddDays(7);

            DateTime d6 = new DateTime(2000, 10, 15);
            DateTime d7 = new DateTime(2000, 10, 18);

            TimeSpan t = d7.Subtract(d6);

            Console.WriteLine(t);


            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine(d4);
            Console.WriteLine(d5);
            */

            /*
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine();
            Console.WriteLine(t4);
            Console.WriteLine($"Days: {t4.Days}");
            Console.WriteLine($"Hours: {t4.Hours}");
            Console.WriteLine($"Minutes: {t4.Minutes}");
            Console.WriteLine($"Seconds: {t4.Seconds}");
            Console.WriteLine($"Milliseconds: {t4.Milliseconds}");
            Console.WriteLine($"Ticks: {t4.Ticks}");

            Console.WriteLine($"TotalDays; {t4.TotalDays}");
            Console.WriteLine($"TotalHours: {t4.TotalMinutes}");
            Console.WriteLine($"TotalMinutes: {t4.TotalMinutes}");
            Console.WriteLine($"TotalSeconds: {t4.TotalSeconds}");
            Console.WriteLine($"TotalMilliseconds: {t4.TotalMilliseconds}");
            */

            /*
            TimeSpan t1 = new TimeSpan(1, 30, 10);

            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply((2.0));
            TimeSpan divide = t2.Divide(2);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(divide);
            */

            /*
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine();
            Console.WriteLine($"d1 {d1}");
            Console.WriteLine($"d1 kind: {d1.Kind}");
            Console.WriteLine($"d1 to Local: {d1.ToLocalTime()}");
            Console.WriteLine($"d1 to Utc: {d1.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine($"d2 {d2}");
            Console.WriteLine($"d2 kind: {d2.Kind}");
            Console.WriteLine($"d2 to Local: {d2.ToLocalTime()}");
            Console.WriteLine($"d2 to Utc: {d2.ToUniversalTime()}");
            Console.WriteLine();
            Console.WriteLine($"d3 {d3}");
            Console.WriteLine($"d3 kind: {d3.Kind}");
            Console.WriteLine($"d3 to Local: {d3.ToLocalTime()}");
            Console.WriteLine($"d3 to Utc: {d3.ToUniversalTime()}");
            */

            //yyyy-MM-ddTHH:mm:ssZ

            /*
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:08");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:08Z");


            Console.WriteLine();
            Console.WriteLine($"d1 {d1}");
            Console.WriteLine($"d1 kind: {d1.Kind}");
            Console.WriteLine($"d1 to Local: {d1.ToLocalTime()}");
            Console.WriteLine($"d1 to Utc: {d1.ToUniversalTime()}");
            
            Console.WriteLine();
            Console.WriteLine($"d2 {d2}");
            Console.WriteLine($"d2 kind: {d2.Kind}");
            Console.WriteLine($"d2 to Local: {d2.ToLocalTime()}");
            Console.WriteLine($"d2 to Utc: {d2.ToUniversalTime()}");
            Console.WriteLine();

            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

            */
























        }


    }
}


