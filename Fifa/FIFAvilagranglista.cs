using System;

namespace Fifa
{
    class Program
    { 
        public string Csapat { get; set; }
           public int Helyezés { get; set; }
        public int Valtozás { get; set; }
        public int Pontszám { get; set; }

        static void Main(string[] args)
        {
               List<Csapat> Csapatok = new List<Csapat>();
            foreach (var sor in File.ReadAllLines("fifa.txt").Skip(1))
            {
                Csapatok.Add(new Csapat(sor));
            }
             Console.WriteLine($"3.feladat: A fifázgatásban  {Csapatok.Count} csapat szerepel.");
        }
    }
}
