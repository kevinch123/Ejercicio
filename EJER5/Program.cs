namespace ejer5
{
    public class program
    {
        public static void Main()
        {
            double Pago, MetrosP, La, Lb, Lc, preciocm, TotPrec;

            Console.WriteLine("digite el lado Ancho de la alberca");
            La = double.Parse(Console.ReadLine());

            Console.WriteLine("digite el largo de la alberca ");
            Lb = double.Parse(Console.ReadLine());

            Console.WriteLine("digite la altura de la alberca ");
            Lc = double.Parse(Console.ReadLine());

            Console.WriteLine("dijite el precio del agua para llenar la alberca por metro cubico");
            preciocm = double.Parse(Console.ReadLine());


            MetrosP = La*Lb*Lc;
            TotPrec = MetrosP * preciocm;

            Console.WriteLine($"La cantidad de metros cubicos sera {MetrosP}cm3");
            Console.WriteLine($"La cantidad de metros cubicos sera {TotPrec}cm3");




        }
    }
}