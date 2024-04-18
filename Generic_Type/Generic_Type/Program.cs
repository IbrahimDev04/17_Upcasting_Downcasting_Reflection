using Generic_Type.Models;

namespace Generic_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.GetElement();
        }
    }
}
