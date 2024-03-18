namespace ConsoleApp1;

public abstract class Kontener
{
    private double masaLadunku;
    private double wysokosc;
    private double masaWlasna;
    private String numerSeryjny;

    protected Kontener(double masaLadunku, double wysokosc, double masaWlasna, string numerSeryjny)
    {
        this.masaLadunku = masaLadunku;
        this.wysokosc = wysokosc;
        this.masaWlasna = masaWlasna;
        this.numerSeryjny = numerSeryjny;
    }
}