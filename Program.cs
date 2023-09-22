namespace ModulNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie Ihre Modul Nummer ein: ");
            int modulNummer = Convert.ToInt32(Console.ReadLine());
            double lbNote;
            Console.Write("Geben Sie Ihre LB Note ein: ");
            {
                while (!double.TryParse(Console.ReadLine(), out lbNote) || lbNote < 1 || lbNote > 6)
                    if (lbNote > 6) { Console.WriteLine("Bitte nur Zahlen von 1 bis 6 verwenden"); };
            }
            double obaNote;
            Console.Write("Geben Sie Ihre OBA Note ein: ");
            {
                while (!double.TryParse(Console.ReadLine(), out obaNote) || obaNote < 1 || obaNote > 6)
                if (obaNote > 6) { Console.WriteLine("Bitte nur Zahlen von 1 bis 6 verwenden"); };
            }
            lbNote = Math.Round(lbNote, 1);
            obaNote = Math.Round(obaNote, 1);

            double modulNote = lbNote * 0.8 + obaNote * 0.2;

            Console.WriteLine(modulNote);

            if (modulNote < 4) { Console.WriteLine("Sie sind ungenügend. Sie haben verkackt"); }
            else
            {
                Console.WriteLine("Sie haben bestanden. Bravo Meister");


            }
        }
    }
}