public delegate string Reform();
class Reforms 
{
    int a, b, c;
    public Reforms(int _a, int _b, int _c) 
    {
        this.a = _a;
        this.b = _b;
        this.c = _c;
    }

    int day()
    {
        return a % 10;       
    }

    int month()
    {
        return b;
    }

    int year() 
    {
        int res = c % 1000;
        res %= 100;
        return res % 10;
    }

    public string res() 
    {
        string result = "";
        result += first[day()]+" " + second[month()] + " " + third[year()];
        return result;
    }



    public string[] first = { "Інноваційна", "Ліберальна", "Надихаюча", "Незалежна", "Проривна", "Демократична", "Вільна", "Громадська", "Цифрова", "Лідерська" };
    public string[] second = { "", "економічна", "судова", "європейська", "інституційна", "урядова", "податкова", "інтегрована", "післявоєнна", "інфраструктурна", "державна", "президентська", "законотворча" };
    public string[] third = { "відбудова", "стратегія", "місія", "реформа", "візія", "модернізація", "екосистема", "реконструкція", "політика", "спроможність" };
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Reforms r = new Reforms(24, 8, 1991);
        Console.WriteLine(r.res());
    }
}