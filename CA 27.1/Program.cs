class Programm
{
    static void Main(string[] args)
    {
        Console.Write("Укадите кол-во рублей:");
        decimal roubles = decimal.Parse(Console.ReadLine());

        decimal roubleDollars = Converter.ToDollars(roubles);
        Console.WriteLine($"В долларах: {roubleDollars:F2}");
        decimal roubleEuros = Converter.ToEuros(roubles);
        Console.WriteLine($"В евро: {roubleEuros:F2}");
        decimal roubleZlotys = Converter.ToZlotys(roubles);
        Console.WriteLine($"В злотах: {roubleZlotys:F2}");
        decimal roubleYuan = Converter.ToYuan(roubles);
        Console.WriteLine($"В юанях: {roubleYuan:F2}");
        decimal roubleRupes = Converter.ToRupes(roubles);
        Console.WriteLine($"В рупях: {roubleRupes:F2}");
    }

}

class Converter
{
    public static decimal ToDollars(decimal rubles)
    {
        return rubles / 90.03m;
    }
    public static decimal ToEuros(decimal rubles)
    {
        return rubles / 98.03m;
    }
    public static decimal ToZlotys(decimal rubles)
    {
        return rubles / 33.3m;
    }
    public static decimal ToYuan(decimal rubles)
    {
        return rubles * 12.3m;
    }
    public static decimal ToRupes(decimal rubles)
    {
        return rubles * 5.03m;
    }
}