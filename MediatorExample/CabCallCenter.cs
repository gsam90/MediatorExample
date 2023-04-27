using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorExample
{
    public class CabCallCenter : ICabCallCenter
    {
        private readonly Dictionary<string, ICab> cabs = new Dictionary<string, ICab>();

        public void BookCab(IPassenger passenger)
        {
            foreach(var cab in cabs.Values.Where(c => c.IsFree))
            {
                if(IsWithinRadius(cab.CurrentLocation, passenger.Location))
                {
                    cab.Assign(passenger.Name, passenger.Address);
                    passenger.Acknowledge(cab.Name);
                }
            }
        }

        public void Register(ICab cab)
        {
            if(!cabs.ContainsValue(cab)) cabs.Add(cab.Name, cab);
        }
        private bool IsWithinRadius(int cabLocation, int passengerLocation) => Math.Abs(cabLocation - passengerLocation) < 5;
    }
}
