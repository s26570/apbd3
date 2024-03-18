class Program
{
    public static void Main(String[] args)
    {
        
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