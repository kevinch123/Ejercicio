namespace ejer4
{
    public class program
    {
        public static void Main()
        {
            double Pulg = 0;
            double  Mt= 0.0254;
            double Cpulg = 0;
            double MeDados= 0;

            Console.WriteLine("Digite la cantidad de metros necesitados  de la tela:");
             MeDados= double.Parse(Console.ReadLine());
            Cpulg=MeDados/Mt;



            Console.WriteLine($"la cantidad de pulgadas de tela que debe pedir es  :{Cpulg}");


        }
    }
}
