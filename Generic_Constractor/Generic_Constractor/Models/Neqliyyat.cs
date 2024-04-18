using _11_Abstract_Virtual_Override.Models;

namespace Generic_Constractor.Models
{
    internal class Neqliyyat<T> where T : Vehicle
    {
        private Car car;

        public T[] NewliyyatVasitesi { get; set; }

        public Neqliyyat(T[] newliyyatVasitesi)
        {
            NewliyyatVasitesi = newliyyatVasitesi;
        }

        public Neqliyyat(Car car)
        {
            this.car = car;
        }
    }
}
