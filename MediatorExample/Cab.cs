using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MediatorExample
{
    public class Cab : ICab
    {
        private readonly string _name;
        private readonly int _location;
        private readonly bool _isFree;

        public Cab(string name, int location, bool isFree)
        {
            _name = name;
            _location = location;
            _isFree = isFree;
        }

        public string Name => _name;

        public int CurrentLocation =>  _location;

        public bool IsFree =>  _isFree;

        public void Assign(string name, string address) => 
            Console.WriteLine($"{Name} assigned to {name} at {address}");

        
    }
}
