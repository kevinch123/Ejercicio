namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            decimal a, b,c;
            decimal ar, at, ato;

            Console.WriteLine("digite el lado A de la figura");
            a = decimal.Parse(Console.ReadLine());

            Console.WriteLine("digite el lado B de la figura");
            b = decimal.Parse(Console.ReadLine());

            Console.WriteLine("digite el lado C de la figura");
            c = decimal.Parse(Console.ReadLine());

            ar=b*c;
            at=((a-c)*b/2);
            ato = ar + at;
            Console.WriteLine($"El resultado del area sera:{ato}");


        }
    } 
         
    
     
}
