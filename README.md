<h1 align="center">🚀 Exceções e Coleções com C#</h1>
<p align="center">
  <strong>Bootcamp WEX - End to End Engineering | DIO.ME</strong><br/>
  <em>Módulo prático - 2 horas (de 91h totais)</em>
</p>

---

## 🧠 Sobre o Projeto

Este repositório contém os exercícios desenvolvidos no módulo **"Exceções e Coleções com C#"**, onde apliquei conceitos essenciais da linguagem C# e do framework .NET. O foco foi exercitar o uso de coleções genéricas, tratamento de exceções, leitura de arquivos e formatação de dados — habilidades essenciais para qualquer desenvolvedor back-end.

📌 Projeto concluído como parte do bootcamp [**WEX – End to End Engineering**](https://www.dio.me), em parceria com a DIO.

---

## 🔍 O que foi explorado?

### 🧩 Coleções Genéricas
- 📚 `Dictionary<string, string>` – chave e valor
- 📬 `Queue<int>` – fila (FIFO)
- 📦 `Stack<int>` – pilha (LIFO)

### ⚠️ Tratamento de Exceções
- `try / catch / finally`
- Leitura segura com `File.ReadAllLines`
- Tratamento de:
  - `FileNotFoundException`
  - `DirectoryNotFoundException`
  - `Exception`

### 🧾 Formatação e Cultura
- 📅 `DateTime` com formatação personalizada
- 💰 `CultureInfo` para:
  - Valores monetários (`ToString("C")`)
  - Porcentagens (`ToString("P")`)
  - Máscaras numéricas

### 👨‍🏫 Programação Orientada a Objetos
- Criação das classes `Pessoa` e `Curso`
- Listagem de objetos com `List<Pessoa>`
- Métodos personalizados e instanciamento de alunos

---

## ⚙️ Tecnologias e Ferramentas

| 💻 Linguagem | 🧩 Framework | 🛠️ Editor |
|-------------|--------------|-----------|
| `C#`         | `.NET`       | `VS Code` ou `Visual Studio` |

📦 Namespaces usados:
- `System.Collections`
- `System.Globalization`
- `System.IO`

---

## 📁 Estrutura do Projeto

📂 `Dicionário`  
📂 `Pilha e Fila`  
📂 `Try/Catch/Finally`  
📂 `Leitura de Arquivo`  
📂 `Formatação de Dados`  
📂 `POO com Pessoa e Curso`

> Cada exercício está organizado, com comentários explicativos e código limpo para facilitar o entendimento.

---

## ▶️ Como executar

```bash
# Clone o repositório
git clone https://github.com/phsmottanerd/Exce-es-e-Cole-es-com-C-.git

# Acesse a pasta do projeto
cd Exce-es-e-Cole-es-com-C-

# Execute com .NET CLI
dotnet run
