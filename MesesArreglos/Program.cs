namespace MesesArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            string[] Meses = new string[12];

            Meses[0] = "Enero";
            Meses[1] = "Febrero";
            Meses[2] = "Marzo";
            Meses[3] = "Abril";
            Meses[4] = "Mayo";
            Meses[5] = "Junio";
            Meses[6] = "Julio";
            Meses[7] = "Agosto";
            Meses[8] = "Septiembre";
            Meses[9] = "Octubre";
            Meses[10] = "Noviembre";
            Meses[11] = "Diciembre";

            string imput = Console.ReadLine();
            int.TryParse(imput, out int result);

            if (result > 0 && result <= 12)
            {
                Console.WriteLine(Meses[result - 1]);
            }
            else
            {
                Console.WriteLine("El dato es incorrecto");
            }
        }
    }
}