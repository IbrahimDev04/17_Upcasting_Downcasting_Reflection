using _11_Abstract_Virtual_Override.Models;
using Generic_Constractor.Models;

namespace Generic_Constractor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Neqliyyat<Car> neqliyyat = new Neqliyyat<Car>(new Car[]
            {
                new Car("sdadf","dsada","fasfaf",234,4234,342,true),
                new Car("sdadsaddf","dsadsadada","fsdaasfaf",1234,14234,1342,false)
            });

            //Neqliyyat<int> neqliyyat1 = new Neqliyyat<int>(new int[] { 2, 3, 6, 2, 4 });
            
                
                
        }
    }
}
