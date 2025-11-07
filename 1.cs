
using System;
class Init {
  static void Main() {
    float c, l, a, p, pm;
    Console.Write("Comprimento: ");
    c = float.Parse(Console.ReadLine());
    Console.Write("Largura: ");
    l = float.Parse(Console.ReadLine());
    Console.Write("Preço por metro Q: ");
    pm = float.Parse(Console.ReadLine());

    a = c * l;
    p = a*pm
    Console.WriteLine("Metros quadrados: "+a.ToString("F2")+"| "+p.ToString("F2")+" Reais no total");


    
  }
}