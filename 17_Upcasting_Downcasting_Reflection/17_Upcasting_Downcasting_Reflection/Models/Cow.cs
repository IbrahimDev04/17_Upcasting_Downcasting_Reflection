namespace _17_Upcasting_Downcasting_Reflection.Models
{
    internal class Cow : Animal
    {
        public void ProduceMilk()
        {
            Console.WriteLine("Milk Producted");
        }

        public Cow(string breed) : base(breed)
        {
        }

        public override void EatFood(Food food)
        {
            if (food is not Grass) 
            {
                Console.WriteLine("Yanlish qida");
                return ;
            }
            Console.WriteLine("MÖÖÖĞĞ NAĞM NAĞM");
        }

        public override void MakeSound()
        {
            Console.WriteLine("MÖÖÖÖÖĞĞĞĞĞ");
        }
    }
}
