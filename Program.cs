using System;
using System.Text;

namespace NovoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("63a11d56-00bd-41f2-a880-8bfebc98389f");
            
            Console.WriteLine(id.ToString().Substring(0, 8));

            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("testando"));
            Console.WriteLine(texto.Contains("Test"));

            var texto2 = "Este texto é um teste";
            Console.WriteLine(texto2.IndexOf("é"));
            Console.WriteLine(texto2.LastIndexOf("s"));
            Console.WriteLine(texto2.ToLower());
            Console.WriteLine(texto2.ToUpper());
            Console.WriteLine(texto2.Insert(5, "AQUI "));
            Console.WriteLine(texto2.Remove(10, 5));
            Console.WriteLine(texto2.Length);
            Console.WriteLine(texto2.Replace("Este", "Isto"));
            Console.WriteLine(texto2.Replace("e", "X"));

            var divisao = texto2.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);

            var resultado = texto2.Substring(5, 5);
            var resultado2 = texto2.Substring(5, texto.LastIndexOf("o"));
            Console.WriteLine(resultado);
            Console.WriteLine(resultado2);

            Console.WriteLine(texto2.Trim());

            texto2 += " aqui";

            Console.WriteLine(texto2);

            var texto3 = new StringBuilder();
            texto3.Append("Este texto é um texto maluco");
            texto3.Append(" texto maluco");
            texto3.Append("Este  maluco");
            texto3.Append("Este texto é  maluco");

            texto3.ToString();
            Console.WriteLine(texto3);




        }
    }
}
