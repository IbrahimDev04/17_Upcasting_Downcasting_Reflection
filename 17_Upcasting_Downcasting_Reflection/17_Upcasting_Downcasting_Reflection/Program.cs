using _17_Upcasting_Downcasting_Reflection.Models;

namespace _17_Upcasting_Downcasting_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion sir = new Lion(true, "Afrika şiri");
            Cow inek = new Cow("Holland ineyi");

            Meat bonfile = new Meat("mal", 3000);
            Grass cemen = new Grass("Çemen", 1100);

            Animal[] animals = { sir, inek };

            foreach (var anim in animals)
            {
                var lion = anim as Lion;
                var cow = anim as Cow;

                if( lion != null)
                {
                    lion.EatFood(cemen);
                    lion.EatFood(bonfile);
                }
                if (cow != null)
                {
                    cow.EatFood(bonfile);
                    cow.EatFood(cemen);
                }
            }
        }
    }
}
