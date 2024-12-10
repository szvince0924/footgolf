namespace footgolf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzok> versenyzok = new();

            foreach (var sor in File.ReadAllLines("fob2016.txt"))
            {
                versenyzok.Add(new Versenyzok(sor));  
            }



            Console.WriteLine($"3.feladat: versenyzok szama:{versenyzok.Count} ");

            int versenyzok_szama = versenyzok.Count;
            int noi = 0;
            foreach (var v in versenyzok)
            {
                if (v.Kategoria =="noi")
                {
                    noi++;
                }
            }
            Console.WriteLine($"4.feladat: A Noi versenyzok aranya: ");
        }
     

      
    }
}
