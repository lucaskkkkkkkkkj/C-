
using System;
class Init {
  static void Main() {
    string n, nn;
    int i, ii;
    float m;
    Console.Write("Nome: ");
    n = Console.ReadLine();
    Console.Write("Idade: ");
    i = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    nn = Console.ReadLine();
    Console.Write("Idade: ");
    ii = int.Parse(Console.ReadLine());
    m = (i+ii)/2;
    Console.Write("Nomes: "+n+", "+nn);
    Console.WriteLine("Media idade: "+m.ToString("F2"));
    
  }
}