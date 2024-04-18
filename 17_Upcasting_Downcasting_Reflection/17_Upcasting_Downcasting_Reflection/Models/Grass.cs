namespace _17_Upcasting_Downcasting_Reflection.Models
{
    internal class Grass : Food
    {
        public string Name;
        public Grass(string name, decimal calorie) : base(calorie)
        {
            Name = name;
        }
    }
}
