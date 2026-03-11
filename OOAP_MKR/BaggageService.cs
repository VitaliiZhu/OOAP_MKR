using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP_MKR
{
    public class BaggageService
    {
        private List<Passenger> _passengers = new List<Passenger>();

        public void AddPassenger(Passenger p) => _passengers.Add(p);

        // Патерн Delegation: Сервіс не формує рядок сам, 
        // він делегує це методу GetBaggageInfo конкретного пасажира
        public string FindBaggageByTicket(string ticket)
        {
            var passenger = _passengers.FirstOrDefault(p => p.TicketNumber == ticket);
            if (passenger != null)
            {
                return passenger.GetBaggageInfo(); // Делегування
            }
            return "Багаж за таким квитком не знайдено.";
        }
    }
}
