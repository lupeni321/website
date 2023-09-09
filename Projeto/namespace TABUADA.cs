namespace TABUADA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nro, cont = 1;
            //FAZER ALGUMA TABUADA
            Console.Write("Informe um numero para multiplicar: ");
            nro = Convert.ToInt32(Console.ReadLine());

            while (cont <= 10)
            {
                Console.WriteLine(nro+" x "+cont+" = "+ cont * nro);
                cont++;
            }
            Console.ReadKey();
        }
    }
}