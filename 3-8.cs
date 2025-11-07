using System;
class Init{
    static void Main(){
        while (true)
        {
            Console.Write("Selecione a questão, professor(menos a 1 e a 2 pq eu ja lhe mandei separado): ");
            string q = Console.ReadLine();

            if (q == "3")
            {
                int p, vp, t;
                Console.Write("Preço: ");
                p = int.Parse(Console.ReadLine());
                Console.Write("Valor dado: ");
                vp = int.Parse(Console.ReadLine());
                t = vp - p;
                Console.WriteLine("Troco foi: " + t);
            }
            else if (q == "4")
            {
                int[] n = new int[6];
                int nf;
                double m1 = 0, m2 = 0, mf;

                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Digite a nota {i + 1}: ");
                    n[i] = int.Parse(Console.ReadLine());
                    m1 += n[i];
                }
                m1 /= 3;

                for (int i = 3; i < 6; i++)
                {
                    Console.Write($"Digite a nota {i + 1}: ");
                    n[i] = int.Parse(Console.ReadLine());
                    m2 += n[i];
                }
                m2 /= 3;

                Console.Write("Digite a 7ª nota: ");
                nf = int.Parse(Console.ReadLine());

                mf = (m1 + m2 + nf) / 3;

                if (mf < 60)
                    Console.WriteLine("C");
                else if (mf < 80)
                    Console.WriteLine("B");
                else
                    Console.WriteLine("A");
            }
            else if (q == "5")
            {
                float ps, a, imc;
                Console.Write("Peso: ");
                ps = float.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                a = float.Parse(Console.ReadLine());
                imc = ps / (a * a);
                Console.WriteLine("IMC: " + imc.ToString("F2"));
            }
            else if (q == "6")
            {
                int m;
                Console.Write("Minutagem: ");
                m = int.Parse(Console.ReadLine());

                if (m > 100)
                {
                    int extra = (m - 100) * 2;
                    Console.WriteLine("O valor de acréscimo foi: " + extra + " Reais");
                }
                else
                {
                    Console.WriteLine("Dentro do plano");
                }
            }
            else if (q == "7")
            {
                int id;
                Console.Write("1. MORROS / 2. BARRERINHAS / 3. BACABEIRA / 4. ROSARIO: ");
                id = int.Parse(Console.ReadLine());

                if (id == 1)
                    Console.WriteLine("O valor será: " + (120 * 2 * 0.9));
                else if (id == 2)
                    Console.WriteLine("O valor será: " + (200 * 2 * 0.9));
                else if (id == 3)
                    Console.WriteLine("O valor será: " + (50 * 2 * 0.9));
                else if (id == 4)
                    Console.WriteLine("O valor será: " + (80 * 2 * 0.9));
                else
                    Console.WriteLine("Não temos essa viagem");
            }
            else if (q == "8")
            {
                int g;
                Console.Write("Glicose: ");
                g = int.Parse(Console.ReadLine());
                if (g <= 100)
                    Console.WriteLine("Normal");
                else if (g <= 140)
                    Console.WriteLine("Elevado");
                else
                    Console.WriteLine("Diabetes");
            }
        }
    }
}

