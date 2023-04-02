# Abstração

**Uma classe é um tipo customizado que contém a abstração de um objeto.** 

**Exemplificando, uma classe possui em seu corpo todas as informações necessárias para que você possa criar instâncias desse objeto e acessar suas propriedades ou funcionalidades em diferentes contextos.**

*_Cada classe deve ser contida em seu próprio arquivo._*  
  
```csharp
// Exemplo de declaração de classe no C#;

public class Example
{

}

// Exemplo de instanciamento de uma classe c#;

var instance = new Example();
```
  
As classes são tipos de referência, ou seja, toda vez que instanciar uma variável do com uma determinada classe, essa variável irá salvar uma referência a uma instância dessa classe, e não à classe em si.

Ao realizar a instancia, os seguintes passos, de forma bem resumida, acontecem:  

* Instancie o objeto como representação concreta de uma determinada classe;

* Salve as informações específicas dessa instância em um lugar da memória separado para esse fim, que não é o mesmo no qual ele salva as variáveis em si;

* Atribua à variável onde a instância foi criada apenas uma referência ao local da memória onde ela foi salva.

