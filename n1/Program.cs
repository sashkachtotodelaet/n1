public class sdelau
{
    static double finput()
    {
        try
        {
            double pr = Convert.ToDouble(Console.ReadLine());
            return pr;
        }
        catch
        {
            Console.WriteLine("Ввел хуйню, давай по-новой");
            return finput();
        }
    }
    public static void Main()
    {
        Console.WriteLine("Напиши цифру");
        double n = finput();
        Console.WriteLine((n == (int)n) ? "целое" : "нихуя, дробное");
    }
}