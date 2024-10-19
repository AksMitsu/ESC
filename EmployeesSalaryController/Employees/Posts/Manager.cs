using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Server.Employees.Posts
{
    public class Manager : Employee
    {
        private double ContractBonus;
        public Manager(string name, double salary, double hours, double tax) : base(name, salary, hours, tax)
        {
            _post = "Manager";
        }

        //Расчет зарплаты для руководителей
        public override double CalcTotalSalary()
        {
            double salary = base.CalcTotalSalary();
            return (salary * WorkedHours + ContractBonus) * Tax;
        }

        //Добавить сделку
        public void AddContract(double contractPrice, double contractPercent)
        {
            ContractBonus += contractPrice * contractPercent;
        }


        //Улучш. сереиализация
        public override JsonObject Serialize()
        {
            JsonObject result = base.Serialize();
            result.Add("ContractBonus", ContractBonus);
            return result;
        }
        public override void Deserialize(JsonObject json)
        {
            base.Deserialize(json);
            ContractBonus = (double)json["ContractBonus"];
        }
        public Manager(JsonObject json) : base(json) { }
    }
}
