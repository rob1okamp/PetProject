
class Program
{
    static void Main(string[] args)
    {
        Compare compare = new Compare();
        compare.toMatch();
    }
}

class Compare
{
    public string toMatch ()
    {
        double d1;
        double d2;
        Console.WriteLine("Введите первое число: ");
        d1= Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");
        d2= Convert.ToDouble(Console.ReadLine()); 
        
        if (d1 > d2)
        {
            return "Первое число больше второго";
        }  
        else if (d1 < d2)
        {
            return "Первое число меньше второго";
        }
        else
        {
            return "Числа равны";
        }
    }
}