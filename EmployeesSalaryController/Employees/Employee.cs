using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Server.Employees
{
    public class Employee : IEmployees
    {
        public string Name { get => _name; }
        public string Post { get => _post; }
        public double WorkedHours { get => _hours; }
        public double Salary { get => _salary; }
        public double Tax { get => _tax; }

        protected string _name = "Unnamed";
        protected string _post = "Employee";
        protected double _hours = 0;
        protected double _salary = 30000;
        protected double _tax = 1 - 0.13;

        public Employee(string name, double salary, double hours, double tax)
        {
            _name = name;
            _salary = salary;
            _hours = hours;
            _tax = tax;
        }


        //Добавить рабочии часы для работника
        public void AddHours(double hour)
        {
            _hours += hour;
        }
        //Убрать рабочии часы для работника
        public  void RemoveHours(double hour)
        {
            _hours -= hour;
        }


        //Рассчитать зарплату работника
        public virtual double CalcTotalSalary()
        {
            return Salary;
        }


        //Десериализация объекта из JSON
        public virtual void Deserialize(JsonObject json)
        {
            this._name = (string)json["Name"];
            this._post = (string)json["Post"];
            this._salary = (double)json["Salary"];
            this._hours = (double)json["WorkedHours"];
            this._tax = (double)json["Tax"];
        }
        //Сериализация объекта в JSON
        public virtual JsonObject Serialize()
        {
            JsonObject json = new JsonObject();
            json.Add("Name", Name);
            json.Add("Post", Post);
            json.Add("Salary", Salary);
            json.Add("WorkedHours", WorkedHours);
            json.Add("Tax", Tax);
            return json;
        }


        //Установить налог для работника
        public virtual void SetTaxes(double tax)
        {
            _tax = tax;
        }


        //Отправка на клиент
        public virtual JsonObject ToJson()
        {
            JsonObject json = new JsonObject();
            json.Add("Name", Name);
            json.Add("Post", Post);
            return json;
        }
        
        
        public Employee(JsonObject json)
        {
            Deserialize(json);
        }
    }
}
