namespace ejer2
{
    public class program
    {
        public static void Main()
        {
            double LPG = 3.785 ;
            double LV=0;
            double CG = 0;
            double PG=0;
            double ValorVenta=0;

            Console.WriteLine("Digite la cantidad de litros:");
            LV=double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el precio por galon de leche :");
            PG = double.Parse(Console.ReadLine());

            CG=LV/LPG;
            ValorVenta = CG*PG;

            Console.WriteLine($"los litroos de leche a galones son :{CG}");
            Console.WriteLine($"El precio en galones sera :{ValorVenta}");







        }
    }
}