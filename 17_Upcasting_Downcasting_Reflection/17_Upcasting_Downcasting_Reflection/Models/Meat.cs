namespace _17_Upcasting_Downcasting_Reflection.Models
{
    internal class Meat : Food
    {
        public string Type;
        public Meat(string type, decimal calorie) : base(calorie)
        {  
            Type = type;
        }
    }
}
