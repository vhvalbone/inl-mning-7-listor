using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] array1 = { "a", "b", "b", "c", "hej" };
        string[] array2 = { "hej", "a", "a", "b", "programmering" };

        string[] gemensammaSträngar = FinnsIBåda(array1, array2);

        Console.WriteLine("Strängar som finns i båda arrayerna:");
        foreach (string sträng in gemensammaSträngar)
        {
            Console.WriteLine(sträng);
        }
    }

    static string[] FinnsIBåda(string[] array1, string[] array2)
    {
        HashSet<string> gemensammaSträngarSet = new HashSet<string>();

        foreach (string sträng in array1)
        {
            gemensammaSträngarSet.Add(sträng);
        }


        foreach (string sträng in array2)
        {
            if (gemensammaSträngarSet.Contains(sträng))
            {
                gemensammaSträngarSet.Add(sträng);
            }
        }

        return gemensammaSträngarSet.ToArray();
    }
}

