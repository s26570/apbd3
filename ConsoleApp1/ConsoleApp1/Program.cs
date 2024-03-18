class Program
{
    public static void Main(String[] args)
    {
        int[] t = { 1, 2, 3 };
        double s = srednia(t);
        Console.WriteLine(s);
    }

    static double srednia(int[] tab)
    {
        int suma = 0;
        for(int i = 0; i < tab.Length; i++)
        {
            suma = suma + tab[i];
        }

        double srednia = suma / tab.Length;
        return srednia;
    }
}