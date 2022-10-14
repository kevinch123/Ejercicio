namespace ejer3
{
    public class program
    {
        public static void Main()
        {
            double CHP;
            double HT;
            double TP;



            Console.WriteLine("digite el numero de horas trabajadas en la semana :");
            HT = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la cantidad de dinero pagado por hora :");
            CHP = double.Parse(Console.ReadLine());
            
            TP=CHP*HT;



            

            Console.WriteLine($"los litroos de leche a galones son :{TP}");


        }
    }

}
