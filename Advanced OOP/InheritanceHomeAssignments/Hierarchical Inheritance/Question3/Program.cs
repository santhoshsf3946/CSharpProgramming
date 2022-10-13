using System;
namespace Question3;

public class Program
{
    public static void Main(string[] args)
    {
        // Tata class object
        Tata tata = new Tata("HJJHD782474368", 8927483789842, 2938477974284, 20, 89339823, "Sumo");

        tata.ShowInfo();


        // Suzuki class object
        Suzuki suzuki = new Suzuki("HJAGUA899438", 8274984729384, 3242287346827, 15, 78123687, "Jeep");
        suzuki.ShowInfo();
    }
}
