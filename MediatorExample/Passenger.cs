using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorExample
{
    public class Passenger : IPassenger
    {
        private string _name;
        private string _address;
        private int _location;

        public Passenger(string name, string address, int location)
        {
            _name = name;
            _address = address;
            _location = location;
        }

        public string Name => _name;

        public string Address => _address;

        public int Location => _location;

        public void Acknowledge(string name) => 
            Console.WriteLine($"{Name} assigned to {name}");
        
    }
}
