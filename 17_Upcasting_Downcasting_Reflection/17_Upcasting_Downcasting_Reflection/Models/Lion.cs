namespace _17_Upcasting_Downcasting_Reflection.Models
{
    internal class Lion : Animal
    {
        public bool IsPrideLider;
        public Lion(bool isPrideLider, string breed) : base(breed)
        {
            IsPrideLider = isPrideLider;
        }

        public override void EatFood(Food food)
        {
            if (food is not Meat)
            {
                Console.WriteLine("Yanlish qida");
                return;
            }
            Console.WriteLine("RAAAĞRRRR NAĞM NAĞM");
        }

        public override void MakeSound()
        {
            Console.WriteLine("RAAAĞRRRR RAAAĞRRRR");
        }
    }
}
