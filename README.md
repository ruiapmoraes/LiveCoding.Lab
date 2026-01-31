# 💻 LiveCoding.Lab

Um laboratório prático de exercícios de programação em C# com foco em algoritmos e estruturas de dados. Ideal para consolidar conhecimentos através de implementações, testes unitários e análise de complexidade.

## 📋 Sumário

- [Estrutura do Projeto](#estrutura-do-projeto)
- [Exercícios Disponíveis](#exercícios-disponíveis)
- [Como Usar](#como-usar)
- [Tecnologias](#tecnologias)
- [Testes](#testes)
- [Padrão de Implementação](#padrão-de-implementação)
- [Tabela Resumo](#tabela-resumo)

---

## 🏗️ Estrutura do Projeto

```
LiveCoding.Lab/
├── LiveCoding.Lab.Core/              # Implementações dos exercícios
│   ├── Exercises/
│   │   ├── Strings/                  # Exercícios com strings
│   │   │   ├── RemoveVowels.cs
│   │   │   ├── ReverseString.cs
│   │   │   └── PalindromeCheck.cs
│   │   ├── Arrays/                   # Exercícios com arrays
│   │   │   └── TwoSum.cs
│   │   └── StackQueue/               # Exercícios com Stack/Queue
│   │       └── ValidParentheses.cs
│
├── LiveCoding.Lab.App/               # Aplicação console para testar
│   └── Program.cs
│
├── LiveCoding.Lab.Tests/             # Testes unitários (xUnit)
│   ├── Strings/
│   │   ├── RemoveVowelsTests.cs
│   │   ├── ReverseStringTests.cs
│   │   └── PalindromeCheckTests.cs
│   ├── Arrays/
│   │   └── TwoSumTests.cs
│   └── StackQueue/
│       └── ValidParenthesesTests.cs
│
├── README.md
└── .gitignore
```

---

## 📚 Exercícios Disponíveis

### 🔤 Exercícios com Strings

#### 1. **Remove Vowels** (Remover Vogais)

**Arquivo**: `LiveCoding.Lab.Core/Exercises/Strings/RemoveVowels.cs`

**Descrição**:
Remove todas as vogais (maiúsculas e minúsculas) de uma string, mantendo espaços, pontuação e outros caracteres.

**Implementação**:
- Usa `StringBuilder` para construir o resultado (performance)
- Itera por cada caractere verificando se é uma vogal
- Preserva todos os caracteres que não são vogais

**Exemplo de Uso**:
```csharp
var text = "Hello, Live Coding Lab!";
var result = RemoveVowels.Execute(text);
Console.WriteLine(result);  // Saída: "Hll, Lv Cdng Lb!"
```

**Casos de Teste**:
- ✅ Remove todas as vogais (maiúsculas e minúsculas)
- ✅ Preserva espaços e pontuação
- ✅ Retorna string vazia quando entrada é vazia

**Complexidade**:
- Tempo: O(n) - itera uma vez sobre cada caractere
- Espaço: O(n) - resultado tem até n caracteres

---

#### 2. **Reverse String** (Inverter String)

**Arquivo**: `LiveCoding.Lab.Core/Exercises/Strings/ReverseString.cs`

**Descrição**:
Inverte a ordem dos caracteres em uma string, convertendo-a de trás para frente.

**Implementação**:
- Converte string para array de caracteres
- Usa `Array.Reverse()` para inversão in-place
- Reconverte o array para string

**Exemplo de Uso**:
```csharp
var text = "Hello";
var result = ReverseString.Execute(text);
Console.WriteLine(result);  // Saída: "olleH"
```

**Casos de Teste**:
- ✅ Inverte string corretamente
- ✅ Preserva caracteres especiais
- ✅ Retorna string vazia quando entrada é vazia

**Complexidade**:
- Tempo: O(n) - cria array e reverte
- Espaço: O(n) - array de caracteres

---

#### 3. **Palindrome Check** (Verificar Palíndromo)

**Arquivo**: `LiveCoding.Lab.Core/Exercises/Strings/PalindromeCheck.cs`

**Descrição**:
Verifica se uma string é um palíndromo (lê-se igual de trás para frente). Ignora espaços e diferenças de maiúscula/minúscula.

**Implementação**:
- Remove espaços com `Replace()`
- Converte para minúsculas com `ToLowerInvariant()`
- Usa two-pointer approach (esquerda e direita)
- Compara caracteres do início e fim progressivamente

**Exemplo de Uso**:
```csharp
// Palíndromo verdadeiro
var result1 = PalindromeCheck.Execute("A man a plan a canal Panama");
Console.WriteLine(result1);  // Saída: true

// Não é palíndromo
var result2 = PalindromeCheck.Execute("live coding");
Console.WriteLine(result2);  // Saída: false
```

**Casos de Teste**:
- ✅ "radar" retorna true
- ✅ "A man a plan a canal Panama" retorna true (ignora espaços e case)
- ✅ "live coding" retorna false
- ✅ String nula ou vazia retorna false

**Complexidade**:
- Tempo: O(n) - itera até metade da string
- Espaço: O(n) - string limpa sem espaços

**Algoritmo Two-Pointer**:
```
left = 0
right = length - 1

Enquanto left < right:
    Se char[left] != char[right]:
        Retorna false
    left++
    right--
Retorna true
```

---

### 📦 Exercícios com Arrays

#### 4. **Two Sum** (Encontrar Dois Números)

**Arquivo**: `LiveCoding.Lab.Core/Exercises/Arrays/TwoSum.cs`

**Descrição**:
Encontra dois índices em um array cujos valores somam a um alvo específico. Lança exceção se nenhuma solução for encontrada.

**Implementação**:
- Usa `Dictionary<int, int>` para armazenar números visitados e seus índices
- Itera uma única vez sobre o array
- Para cada número, calcula seu complemento (target - número)
- Verifica se o complemento já foi visto no dicionário

**Exemplo de Uso**:
```csharp
var nums = new[] { 2, 7, 11, 15 };
var target = 9;
var result = TwoSum.Execute(nums, target);
Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");  // Saída: Indices: [0, 1]
// nums[0] + nums[1] = 2 + 7 = 9 ✓
```

**Casos de Teste**:
- ✅ Retorna os índices corretos [0, 1] para [2, 7, 11, 15] com target 9
- ✅ Lança `ArgumentException` quando nenhuma solução é encontrada
- ✅ Funciona com números negativos

**Complexidade**:
- Tempo: O(n) - itera uma vez sobre o array
- Espaço: O(n) - dicionário armazena até n números

**Algoritmo Hash Map**:
```
Criar dicionário vazio
Para cada número no array:
    complement = target - número
    Se complement está no dicionário:
        Retorna [índice_anterior, índice_atual]
    Adiciona número ao dicionário com seu índice
Lança exceção (não encontrado)
```

---

### 📚 Exercícios com Stack/Queue

#### 5. **Valid Parentheses** (Validar Parênteses Balanceados)

**Arquivo**: `LiveCoding.Lab.Core/Exercises/StackQueue/ValidParentheses.cs`

**Descrição**:
Verifica se uma string contém parênteses, colchetes e chaves balanceados e corretamente aninhados. Caracteres que não são delimitadores são ignorados.

**Implementação**:
- Usa `Stack<char>` para rastrear parênteses de abertura
- Itera por cada caractere da string
- Caracteres de abertura `(`, `[`, `{` são empilhados (push)
- Caracteres de fechamento `)`, `]`, `}` são comparados com o topo da pilha
- Caracteres não-delimitadores são ignorados
- Retorna true se stack estiver vazia ao final (todos foram pareados)

**Exemplo de Uso**:
```csharp
// Parênteses balanceados
var result1 = ValidParentheses.Execute("{[()]}");
Console.WriteLine(result1);  // Saída: true

// Parênteses desbalanceados
var result2 = ValidParentheses.Execute("{[(])}");
Console.WriteLine(result2);  // Saída: false

// Parênteses incompletos
var result3 = ValidParentheses.Execute("(");
Console.WriteLine(result3);  // Saída: false

// String vazia é válida
var result4 = ValidParentheses.Execute("");
Console.WriteLine(result4);  // Saída: true
```

**Casos de Teste**:
- ✅ `"{[()]}"` retorna true (balanceado e aninhado corretamente)
- ✅ `"{[(])}"` retorna false (aninhamento inválido)
- ✅ `"((()))"` retorna true (múltiplos parênteses)
- ✅ `"("` retorna false (incompleto)
- ✅ `""` retorna true (vazio é válido)
- ✅ `null` retorna false (entrada nula)

**Complexidade**:
- Tempo: O(n) - itera uma vez sobre cada caractere
- Espaço: O(n) - stack pode armazenar até n caracteres

**Estrutura de Dados - Stack**:
```
Push (empilhar):     Adiciona elemento no topo
Pop (desempilhar):   Remove e retorna elemento do topo
Peek:                Visualiza elemento do topo sem remover
Count:               Número de elementos na pilha

Exemplo visual:
     |  |
     | c |  ← Pop() retorna 'c'
     | b |  ← Topo
     | a |
     |___|
```

**Por que usar Stack?**
- Estrutura LIFO (Last In, First Out) é perfeita para validar aninhamento
- Parênteses de fechamento devem corresponder ao último de abertura
- Stack garante a ordem correta de validação

---

## 🚀 Como Usar

### Pré-requisitos
- .NET 10 SDK instalado
- Visual Studio, VS Code ou qualquer editor de C#

### Clonar o Repositório
```bash
git clone https://github.com/ruiapmoraes/LiveCoding.Lab.git
cd LiveCoding.Lab
```

### Executar a Aplicação Console
```bash
dotnet run --project LiveCoding.Lab.App
```

**Output Esperado**:
```
Original input: Hello, Live Coding Lab!
Result after removing vowels: Hll, Lv Cdng Lb!
```

### Executar Testes
```bash
# Executar todos os testes
dotnet test

# Executar testes de um projeto específico
dotnet test LiveCoding.Lab.Tests

# Executar testes de uma classe específica
dotnet test --filter "RemoveVowelsTests"

# Executar com verbosidade detalhada
dotnet test --verbosity detailed
```

### Compilar o Projeto
```bash
dotnet build

# Compilar com configuração Release
dotnet build -c Release
```

---

## 🛠️ Tecnologias

| Tecnologia | Versão | Descrição |
|-----------|--------|-----------|
| **C#** | 14.0 | Linguagem de programação |
| **.NET** | 10 | Framework |
| **xUnit** | Última | Framework de testes |
| **Git** | Versionamento de código |

---

## 🧪 Testes

O projeto utiliza **xUnit** para testes unitários com padrão **AAA (Arrange-Act-Assert)**.

### Exemplo de Teste:
```csharp
public class RemoveVowelsTests
{
    [Fact]
    public void Should_Remove_Vowels_From_String()
    {
        // Arrange
        var input = "Hello, Live Coding Lab!";

        // Act
        var result = RemoveVowels.Execute(input); 

        // Assert
        Assert.Equal("Hll, Lv Cdng Lb!", result);
    }
}
```

### Cobertura de Testes:
- ✅ Casos normais (happy path)
- ✅ Casos extremos (strings vazias, valores null)
- ✅ Variações de entrada (maiúsculas, minúsculas, caracteres especiais)

---

## 📐 Padrão de Implementação

Todos os exercícios seguem um padrão consistente:

```csharp
namespace LiveCoding.Lab.Core.Exercises.[Categoria]
{
    public static class [NomeExercicio]
    {
        public static [ReturnType] Execute([Parametros])
        {
            // Validações iniciais
            if (string.IsNullOrEmpty(input))
                return [valor_padrão];

            // Implementação do exercício

            return resultado;
        }
    }
}
```

### Características do Padrão:
- **Classe estática**: Não precisa de instanciação
- **Método Execute**: Método público com assinatura clara
- **Validações**: Tratamento de null/empty no início
- **Nomeação clara**: Métodos e variáveis descritivos

---

## 📊 Tabela Resumo

| # | Exercício | Tipo | Dificuldade | Complexidade | Tópicos |
|---|-----------|------|-------------|--------------|---------|
| 1 | Remove Vowels | String | ⭐ Fácil | O(n) / O(n) | StringBuilder, String manipulation |
| 2 | Reverse String | String | ⭐ Fácil | O(n) / O(n) | Array reverse, String conversion |
| 3 | Palindrome Check | String | ⭐⭐ Intermediário | O(n) / O(n) | Two-pointer, String normalization |
| 4 | Two Sum | Array | ⭐⭐ Intermediário | O(n) / O(n) | Hash map, Complement calculation |
| 5 | Valid Parentheses | Stack | ⭐⭐ Intermediário | O(n) / O(n) | Stack, Parsing, Aninhamento |

### Legenda:
- **Tempo / Espaço**: Complexidade de Tempo / Espaço
- ⭐ = Nível de dificuldade

---

## 📈 Próximos Passos

- [ ] Adicionar exercícios de estruturas de dados: LinkedList, Min/Max Stack
- [ ] Exercícios de Queue: Task Scheduler, Sliding Window
- [ ] Exercícios de arrays avançados: Three Sum, Merge Sorted Arrays, Remove Duplicates
- [ ] Algoritmos de ordenação: Bubble Sort, Merge Sort, Quick Sort
- [ ] Exercícios de recursão e backtracking
- [ ] Análise detalhada de complexidade com gráficos
- [ ] Benchmarks de performance
- [ ] Documentação com diagramas visuais

---

## 🔗 Links Úteis

- [GitHub Repository](https://github.com/ruiapmoraes/LiveCoding.Lab)
- [.NET 10 Documentation](https://learn.microsoft.com/en-us/dotnet/)
- [xUnit Documentation](https://xunit.net/)
- [C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)

---

## 📝 Notas

- Todos os exercícios incluem testes unitários
- Cada implementação é otimizada para clareza e performance
- O código segue convenções C# padrão
- Comentários explicam lógica complexa quando necessário

---

## 👤 Autor

Projeto desenvolvido como material de estudo em **live coding** sessions.

**GitHub**: [@ruiapmoraes](https://github.com/ruiapmoraes)  
**Repositório**: [LiveCoding.Lab](https://github.com/ruiapmoraes/LiveCoding.Lab)

---

## 📄 Licença

Este projeto está disponível para fins educacionais.

**Última atualização**: 2026  
**Status**: Em desenvolvimento 🔄
