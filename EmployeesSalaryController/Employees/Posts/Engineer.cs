using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Server.Employees.Posts
{
    public class Engineer : Employee
    {
        public Engineer(string name, double salary, double hours, double tax) : base(name, salary, hours, tax)
        {
            _post = "Engineer";
        }


        //Расчет зарплаты для рабочих-инженеров (Почасовая-оплата)
        public override double CalcTotalSalary()
        {
            double salary = base.CalcTotalSalary();
            return (salary * WorkedHours) * Tax;
        }


        public Engineer(JsonObject json) : base(json) { }
    }
}
