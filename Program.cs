using System;
using System.Globalization;
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

            Console.Clear();
            
            var dataNow = DateTime.Now;
            var data = new DateTime(2020, 10, 12, 8, 23, 14);

            data = DateTime.Now;

            Console.WriteLine(dataNow);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Date);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);

            var formato = String.Format("{0:yyyy->MM<-dd hh:mm:ss ff zz}", data);
            Console.WriteLine(formato);


            Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddHours(20));
            Console.WriteLine(data.AddYears(100));

            DateTime? dataNula = null;
            Console.WriteLine(dataNula);

            if(data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual!");
            }

            Console.WriteLine(data.AddMonths(1));

            var pt = new CultureInfo("pt-PT");
            var en = new CultureInfo("en-US");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("y", en));
            Console.WriteLine(DateTime.Now.ToString("y", atual));

            var dateTime = DateTime.UtcNow;
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
            Console.Write(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone ));
                Console.WriteLine("___________________");
            }

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            Console.WriteLine(DateTime.DaysInMonth(2025, 3));

            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

            decimal valor = 10.25m;
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Floor(valor));
            Console.WriteLine(Math.Ceiling(valor));

            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 1322;

            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }

            var funcionarios = new Funcionario[2];
            funcionarios[0] = new Funcionario() { Id = 2000, Nome = "Leonardo" };
            funcionarios[1] =  new Funcionario() { Id = 3000, Nome = "Rodrigo" };

            foreach(var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
            }



        }

        private static bool Format(string v, DateTime data)
        {
            throw new NotImplementedException();
        }

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }

        public struct Funcionario {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

    }
}
