# **Desafio de Lógica de Programação**

Este projeto contém a implementação de cinco desafios de lógica de programação utilizando **C#**. Cada desafio foi desenvolvido para rodar em um **projeto Console Application**, permitindo entrada de dados pelo terminal e apresentando os resultados na saída padrão.

## **Índice**
- [Arquitetura](#arquitetura)
- [Funcionalidades](#funcionalidades)
- [Exemplos de Entrada e Saída](#exemplos-de-entrada-e-saída)
- [Instruções de Execução](#instruções-de-execução)
- [Instalação do Newtonsoft.Json](#instalação-do-newtonsoftjson)
- [Melhorias Futuras](#melhorias-futuras)

---

## **Arquitetura**
O projeto foi desenvolvido utilizando **.NET Core** com **C#**, garantindo uma estrutura simples e funcional. O código foi modularizado para facilitar manutenção e expansão futura.

O desafio de **processamento do faturamento diário** utiliza um **arquivo JSON** como fonte de dados, o que permite testes mais realistas.

---

## **Funcionalidades**
Os desafios implementados são:

1. **Cálculo da variável SOMA** - Processa um laço de repetição e calcula o resultado final.
2. **Verificação de número na sequência de Fibonacci** - Identifica se um número pertence à sequência de Fibonacci.
3. **Processamento do faturamento diário** - Lê um JSON e retorna informações sobre faturamento mínimo, máximo e número de dias acima da média.
4. **Cálculo do percentual de faturamento por estado** - Determina a porcentagem de faturamento de cada estado em relação ao total.
5. **Inversão de string** - Inverte uma string sem usar funções prontas.

---

## **Exemplos de Entrada e Saída**
Aqui estão exemplos de execução para cada desafio:

### **1️⃣ Cálculo da variável SOMA**
✅ **Saída esperada:**
Resultado da variável SOMA: 91

### **2️⃣ Verificação de número na sequência de Fibonacci**
✅ **Entrada:**
Informe um número: 21
✅ **Saída esperada:**
21 pertence à sequência de Fibonacci.

✅ **Entrada:**
Informe um número: 50
✅ **Saída esperada:**
❌ **Entrada inválida:**

Informe um número: abc
✅ **Saída esperada:**
❌ **Entrada inválida:**

 **3️⃣ Processamento do faturamento diário**
**Exemplo de arquivo `faturamento.json`:**
[
    {"Dia": 1, "Valor": 1500.50},
    {"Dia": 2, "Valor": 1000.00},
    {"Dia": 3, "Valor": 0.00},
    {"Dia": 4, "Valor": 2000.75},
    {"Dia": 5, "Valor": 3000.30}
]


✅ **Saída esperada:**
Menor faturamento: 1000
Maior faturamento: 3000.3
Dias acima da média: 2

Caso o arquivo não exista:
 Arquivo de faturamento não encontrado.

**4️⃣ Percentual de faturamento por estado**
✅ **Saída esperada:**
SP: 37,53%
RJ: 20,29%
MG: 16,17%
ES: 15,03%
Outros: 10,98%

**5️⃣ Inversão de string**
✅ **Entrada:**
Digite uma palavra: Pacemind
✅ **Saída esperada:**
Invertida: dnimecaP

❌ Entrada inválida (string vazia):
Digite uma palavra: 
✅ **Saída esperada:**
Erro: A string não pode estar vazia.


## **Instruções de Execução**
### **Pré-requisitos**
Antes de executar o projeto, certifique-se de ter os seguintes itens instalados em seu sistema:

- [.NET 8.0 ou superior](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio / VS Code](https://visualstudio.microsoft.com/) ou qualquer outro terminal compatível com .NET

## **Instruções de Execução**

### **Clonar o Repositório**
Para obter o código fonte, clone o repositório do GitHub:
```sh
git clone https://github.com/marco-lima-1/TesteTargetSistemas.git
cd TesteTargetSistemas

## **Executar Localmente no Terminal**
Para rodar o projeto via terminal, utilize os comandos abaixo:
dotnet build
dotnet run

## **Executar pelo Visual Studio**
Abra o Visual Studio.
No menu, clique em "Abrir um projeto ou solução".
Navegue até a pasta do projeto e selecione o arquivo .csproj.
Clique em Executar (Botão "Iniciar" ou tecla F5).
