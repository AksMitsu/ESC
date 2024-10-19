using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Server.Employees
{
    public interface IEmployees
    {
        string Name { get; }
        string Post { get; }
        double WorkedHours { get; }
        double Salary { get; }
        double Tax { get; }

        double CalcTotalSalary();
        void AddHours(double hour);
        void RemoveHours(double hour);
        void SetTaxes(double tax);
        JsonObject ToJson();
        JsonObject Serialize();
        void Deserialize(JsonObject jobject);

    }
}
