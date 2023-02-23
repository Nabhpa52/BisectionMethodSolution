internal class Program
{
    private static double a,b,c,d;
    private static void Main(string[] args)
    {
        string q;
        do
        {
            double x, m, n, prev = int.MaxValue;
            Console.WriteLine("Enter the value of equations!");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for bounds ");
            m = double.Parse(Console.ReadLine());
            n = double.Parse(Console.ReadLine());
            while (true)
            {
                x = (m + n) / 2;

                if (eqn(x) == 0)
                {
                    Console.WriteLine("Equation Solved for x="+x);
                    break;
                }
                else if (prev == eqn(x))
                {
                    Console.WriteLine("Similar Result...");
                    Console.WriteLine("x = " + x);
                    Console.WriteLine(eqn(x));
                    break;
                }
                else
                {
                    Console.WriteLine("m = " + m + ", n = " + n + ", x = " + x);
                    if (eqn(x) * eqn(m) < 0)
                    {
                        n = x;
                    }
                    else
                    {
                        m = x;
                    }
                }
                prev = eqn(x);
            }
            Console.WriteLine("Enter k to continue...");
            q = Console.ReadLine();
        } while (q == "k");
        string hold = Console.ReadLine();
    }
    private static double eqn(double x)
    {
        return a*Math.Pow(x, 3) + b * Math.Pow(x,2) + c*x + d;
    }
}
    