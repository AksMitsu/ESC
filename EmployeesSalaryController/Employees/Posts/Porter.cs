using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Server.Employees.Posts
{
    public class Porter : Employee
    {
        private double Items;
        private double ItemPrice;
        public Porter(string name, double salary, double hours, double tax) : base(name, salary, hours, tax)
        {
            _post = "Porter";
        }
        

        //Расчет зарплаты для сдельщиков
        public override double CalcTotalSalary()
        {
            double salary = base.CalcTotalSalary();
            return (salary * WorkedHours + Items * ItemPrice) * Tax;
        }


        //Item использется в качестве предмета за ед. которого выплачиваются деньги
        public void AddItem(double item) { Items += item; }
        public void RemoveItem(double item) { Items -= item; }
        public void SetItemPrice(double itemPrice) { ItemPrice = itemPrice; }


        //Улучш. сериализация
        public override JsonObject Serialize()
        {
            JsonObject result = base.Serialize();
            result.Add("Items", Items);
            result.Add("ItemPrice", ItemPrice);
            return result;
        }
        public override void Deserialize(JsonObject json)
        {
            base.Deserialize(json);
            Items = (double)json["Items"];
            ItemPrice = (double)json["ItemPrice"];
        }
        public Porter(JsonObject json) : base(json) { }
    }
}
