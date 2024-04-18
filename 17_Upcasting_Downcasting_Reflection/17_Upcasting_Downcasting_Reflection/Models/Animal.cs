namespace _17_Upcasting_Downcasting_Reflection.Models
{
    internal abstract class Animal
    {
        public string Breed;

        public abstract void MakeSound();

        protected Animal(string breed)
        {
            Breed = breed;
        }
        public abstract void EatFood(Food food);

    }
}
