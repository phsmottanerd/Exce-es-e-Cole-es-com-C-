using ExemploExplorando.Models;
using System.Collections;
using System.Globalization;

// Exercício 1: Dicionário de Estados
Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");
Console.WriteLine(estados["MG"]);

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor:{item.Value}");
}
Console.WriteLine("______________");
estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor:{item.Value}");
}

string chave = "BA2";
Console.WriteLine($"Verificando o elemento {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}");
}

// Exercício 2: Pilha (Stack)
Stack<int> pilha = new Stack<int>();
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
pilha.Push(20);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

// Exercício 3: Fila (Queue)
Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

// Exercício 4: Tratamento de Exceções
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Diretório não encontrado: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro genérico: {ex.Message}");
}
finally
{
    Console.WriteLine("Bloco finally executado");
}

// Exercício 5: DateTime formatado
DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH.mm"));

// Exercício 6: Formatação com CultureInfo
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
decimal valorMonetario = 1582.40M;
Console.WriteLine(valorMonetario.ToString("N2"));

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 12345;
Console.WriteLine(numero.ToString("##-##-##"));

// Exercício 7: Exibir valor monetário com cultura diferente
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine($"{valorMonetario:C}");

// Exercício 8: Soma de números
int numero1 = 10;
int numero2 = 20;
int resultado = numero1 + numero2;
Console.WriteLine(resultado);

// Exercício 9: Objetos e Listas
Pessoa p1 = new Pessoa(nome:"Leonardo", sobrenome:"Buta");
Pessoa p2 = new Pessoa(nome:"Eduardo", sobrenome:"Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

// Exercício 10: Instância simples de Pessoa
Pessoa p3 = new Pessoa();
p3.Nome = "Leonardo";
p3.Sobrenome = "Buta";
p3.Idade = 20;
p3.Apresentar();