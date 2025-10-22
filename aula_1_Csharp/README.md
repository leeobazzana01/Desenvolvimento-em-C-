# Aula I
Introdução geral ao framework e noções gerais de POO.

## Introdução
O Framework DOTNET foi criado pela Microsoft para competir com Java.

As aulas irão abordar DOTNET e orientação a Objeto.

O DOTNET é bastante usado pois gera packages e você pode exportar e reutilizar o DOTNET. 

Ele possui divisão em Ecossistemas .NET, sendo as principais:

1. **ASP.NET** para desenvolvimento web com Server Side Randing, com o front em Blazor por ser executado em Web Assembly.
2. **Xamarin**: Desenvolvimento de Apps Mobile. Quando surgiu foi muito revolucionário, por rodar em Android, IOS, Linux, Windows, etc... Porém, precisava de uma máquina com muito processamento, era muito pesado e acabou perdendo espaço no mercado.
3. **Entity Framework**: banco de dados ORM (Object Relacional Map). Permite escrever código que já manipula o banco de dados diretamente.

## Conteúdo da Aula

### Introdução a API

A API (Aplication Program Interface), basicamente é um sistema que permite a comuniacação entre a API, o FrontEnd e o Backend. É como se fosse o Garçom de um Restaurante, pois leva o cardápio, atende o cliente (front), leva o pedido à cozinha (requisição) e retorna levando um prato ao cliente. Além de permitir a comunicação entre o Front e o Back, uma API também permite a comunicação entre serviços internos, por exemplo o Mercado Livre tem cerca de 70 API's, cada uma delas para um serviço, que se comunicam entre si.

No exemplo do Bruno, que trabalha com validação de cartões, a verificação é em 2 etapas:

1. Validar a transação (se é fraudulenta ou não) e enviar para Mastercard
2. Comunicação entre API de cartões e a API da empresa
3. Confirmação de Etapas (feito em uma segunda API), buscando os dados da primeira e confirmando a partir dos dados da Mastercard (possibilitar mais segurança utilizando Tokens)

Essa estruturação permite Abstração de Funcionalidades (não preicsar saber como a API de cartões funciona, conhecendo apenas os End Points), Reutilização de Códigos, Segurança e controle. As API´s geralmente possuem dois formatos: JSON e XML. 

As vantagens do JSON:
1. Leve e Legível
2. Facilidade de uso: sintaxe simples e possibilita manipulação de Dados
3. Suporte Nativo
4. Eficiente em termos de Espaço (pacote de dados é bem leve)

As vantagens do XML:
1. Extensibilidade: o Governo utiliza para validações fiscais
2. Suporta Metadados: consegue trabalhar com um grande conjunto de dados 
3. Usabilidade: muito utilizado por empresas de ERP pequenas/médias

Desvantagens de XML:
1. Verbosidade: escrito em Tags, dificultando a identificação de erros e bugs. Um erro na escrita de código pode quebrar toda a nota

## Orientação a Objetos
É o principal paradigma do C#.

É composto por: Objetos (resultados),  Atributos(características), Construtor(para criar um objeto) e Métodos(ação).

Os objetos são **equivalentes** a uma **struct**, na Struct nós alocamos dados na stack que é ótimo para acessar os dados porém com pouca duração na memória, porém a classe aloca na Heap (fica em memória por mais tempo).  

### **Classes**

A principal diferença entre Classe e Objetos é que a classe **define o modelo daquele dado, como iremos estruturá-lo**. O objeto é **tipo de dado fruto naquele modelo**.

No exemplo abaixo, a classe Biscoito é criada. Objetos seriam por exemplo, biscoitoPolvilho (com a receita do biscoito), biscoito chocolate, entre outros vários que poderíamos criar usando como "molde" essa classe "Biscoito" que criamos. 

```C#
//classse que representa receira
class Biscoito{
    //atributos (características)
    public int Farinha { get; set; }
    public int Acucar { get; set; }
    public int Ovos { get; set; }

    //construtor (o que cria as receitas de bolo)
    //o construtor pode ser vazio 
    public biscoito(int farinha, int acucar, int ovos){
        this.Farinha = farinha;
        this.Acucar = acucar;
        this.Ovos = ovos;
    }
}
```

### Atributos
São as características, os ingreditentes que iremos utilizar na receita, na Classe acima, por exemplo, os atributos definidos foram int Farinha, Acucar, Ovos.

### Métodos
Ações que as classes fazem, por exemplo no caso da receita, preparar massa, moldar biscoitos, assar biscoitos, etc...

### Objetos
Enquanto a classe é uma receita, o objeto é o resultado disso. O objeto é o que criamos, por exemplo, usando a receita acima poderíamos criar um objeto biscoito1, biscoito2, biscoito3, cada um com uma receita e proporção diferentes.

### Herança
A herança consiste em **herdar algo de uma classe para outra**. Por exemplo, temos a classe **Biscoito**, podemos criar uma classe de **Biscoito de chocolate** que **herda as características (atributos)** da classe anterior criada.

## Implementação e Extensão

### Interface
Meios de te dizer como fazer algo sem dizer como. Por exemplo, na interface biscoito, o usuário consegue utilizar os métodos criados, porém sem saber como isso foi desenvolvido. O desenvolvedor é quem determina isso, declarando os métodos e atributos que uma classe espera ao ser utilizada.

No caso do códio abaixo, quando criamos o objeto ele utilizou a classe anteriormente criada, essa interface permitiu ao usuário utilizar sem necessariamente saber como o código foi desenvolvido.

```C#
namespace Receitas
{
    public interface IReceita
{
    public void Moldar();
    public void Preparar();
    public void Assar();
}

public class BoloChocolate : IReceita
{
    public int farinha {get; set;}
    public int acucar {get; set;}
    public int ovos {get; set;}
    public int chocolate {get; set;}

    public void Moldar()
    {
        Console.WriteLine("Moldando a massa");
    }
    public void Preparar()
    {
        Console.WriteLine("Preparando forma e forno");
    }
    public void Assar()
    {
        Console.WriteLine("Assando a 100 graus por 20 minutos");
    }
}

class Pudim : IReceita {
    public int leiteCondensado { get; set; }
    public int acucar { get; set; }
    public int ovos { get; set; }

    public void Moldar()
    {
        Console.WriteLine("Moldando a massa");
    }
    public void Preparar()
    {
        Console.WriteLine("Preparar caramelo");
    }
    public void Assar()
    {
        Console.WriteLine("Assando em banho maria por 40 minutos");
    }

    static void Main(){
        Pudim pudim_vo = new Pudim();
        pudim_vo.Moldar();
        pudim_vo.Preparar();
        pudim_vo.Assar();
    }
}
}
```
### Contratos

