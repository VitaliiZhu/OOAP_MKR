using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAP_MKR
{
    public partial class Form1 : Form
    {
        private BaggageService _service;
        public Form1()
        {
            InitializeComponent();
            _service = new BaggageService();
            SeedData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SeedData()
        {
            var p1 = new Passenger("Іван Петренко", "UKR123");
            p1.Items.AddRange(new[] { "Валіза 15кг", "Рюкзак" });

            var p2 = new Passenger("Марія Коваль", "FLY789");
            p2.Items.Add("Дипломат");

            var p3 = new Passenger("Руслан Попов", "FLY345");
            p3.Items.Add("Валіза 10кг");

            var p4 = new Passenger("Анна Мельник", "FLY228");
            p4.Items.Add("Рюкзак");
            
            var p5 = new Passenger("Юрій Прохоров", "UKR148");
            p5.Items.AddRange(new[] { "Валіза 10кг", "Рюкзак" });
            
            _service.AddPassenger(p1);
            _service.AddPassenger(p2);
            _service.AddPassenger(p3);
            _service.AddPassenger(p4);
            _service.AddPassenger(p5);

            listBoxPassengers.Items.Add("UKR123 - Іван Петренко");
            listBoxPassengers.Items.Add("FLY789 - Марія Коваль");
            listBoxPassengers.Items.Add("FLY345 - Руслан Попов");
            listBoxPassengers.Items.Add("FLY228 - Анна Мельник");
            listBoxPassengers.Items.Add("UKR148 - Юрій Прохоров");
        }
        private void btnCheckBaggage_Click(object sender, EventArgs e)
        {
            string ticket = txtTicketNumber.Text.Trim();

            string result = _service.FindBaggageByTicket(ticket);

            MessageBox.Show(result, "Інформація про багаж");
        }
    }
}
