# Construtores

Construtores são métodos chamados toda vez que uma instância de uma classe é criada, ou seja, mesmo que não tenhamos definido um construtor customizado para determinada Classe, ela terá um construtor padrão, o qual não aceitará nenhum parâmetro nem definirá nenhuma propriedade.

Todavia, podemos querer aceitar parâmetros e definir propriedades na hora de instanciar um objeto. Tudo o que precisamos fazer é definir um método construtor.

```csharp
// Exemplo de uso do construtor;

public class Example
{
  string Name;

  public Example(string name)
  {
    Name = name;
  }
}

```

*_A palavra-chave public que precede o construtor é necessária caso você queira criar uma instância da classe a partir de outro lugar que não seja a própria classe._*

