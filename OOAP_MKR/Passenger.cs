using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP_MKR
{
    public class Passenger
    {
        public string Name { get; set; }
        public string TicketNumber { get; set; }
        public List<string> Items { get; set; } = new List<string>();

        public Passenger(string name, string ticket)
        {
            Name = name;
            TicketNumber = ticket;
        }

        public string GetBaggageInfo()
        {
            return Items.Count > 0
                ? $"{Name} (Квиток: {TicketNumber}) має: {string.Join(", ", Items)}"
                : $"{Name} не має зареєстрованого багажу.";
        }
    }
}

