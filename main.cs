using System;

class MainClass {
  public static void Main () {

    int nota1, nota2, nota3, nota4, soma;
    float media;

    Console.Write("Digite a primeira nota >>");
    nota1 = int.Parse(Console.ReadLine());

    Console.Write("Digite a segunda nota >>");
    nota2 = int.Parse(Console.ReadLine());

    Console.Write("Digite a terceira nota >>>");
    nota3 = int.Parse(Console.ReadLine());

    Console.Write("Digite a quarta nota >>");
    nota4 = int.Parse(Console.ReadLine());

    soma = nota1 + nota2 + nota3 + nota4;
    media = soma / 4;

    Console.Write("A média das notas é > {0}", media);

  }
} 