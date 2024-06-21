namespace Programowanie_obiektowe_Zadanie2;

public class Protokat
{
    private double _bokA;
    private double _bokB;
    
    public double BokA
    {
        get { return _bokA;  }
        set
        {
            if (!double.IsFinite(value) || value < 0)
            {
                throw new ArgumentException("BokA musi być skończoną, nieujemną liczbą.");
            }
            _bokA = value;
        }
        
    }

    public double BokB
    {
        get { return _bokB; }
        set
        {
            if (!double.IsFinite(value) || value < 0)
            {
                throw new ArgumentException("BokB musi być skończoną, nieujemną liczbą.");
            }
            _bokB = value;
        }
    }

    public static readonly Dictionary<char, decimal> WysokoscArkusza0 = new Dictionary<char, decimal>
    {
        ['A'] = 1189,
        ['B'] = 1414,
        ['C'] = 1297
    };
    
    public Protokat(double bokA, double bokB)
     {
         BokA = bokA;
         BokB = bokB;
     }

    public static Protokat ArkuszPapieru(string formatArkusza)
    {
        char xFormatu = formatArkusza[0];

        if (!WysokoscArkusza0.ContainsKey(xFormatu))
        {
            throw new ArgumentException("Zla nazwa serii formatu");
        }

        byte i = byte.Parse(formatArkusza.Substring(1));

        decimal wysokoscArkuszaPapieru = WysokoscArkusza0[xFormatu];

        double pierwiastekz2 = Math.Sqrt(2);

        double wysokoscBokuA = (double)wysokoscArkuszaPapieru / Math.Pow(pierwiastekz2, i);
        double wysokoscBokuB = wysokoscBokuA / pierwiastekz2;

        return new Protokat(wysokoscBokuA, wysokoscBokuB);
        
    }
}