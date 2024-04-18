namespace _17_Upcasting_Downcasting_Reflection.Models
{
    internal abstract class Food
    {
        public decimal Calorie;

        protected Food(decimal calorie)
        {
            Calorie = calorie;
        }
    }
}
