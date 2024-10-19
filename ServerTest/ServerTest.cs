using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Server;
using Server.Employees;
using Server.Employees.Posts;
using System.Collections.Immutable;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Xml.Linq;

namespace ServerTest
{
    [TestClass]
    public class ServerTest
    {

        TcpListener tcpListener = new TcpListener(IPAddress.Any, 7777);
        List<IEmployees> employees = new List<IEmployees>();

        /*[TestMethod]
        public void ServerStartTest()
        {
            //arrenge

            //act

            //assert

        }*/

        [TestMethod]
        public void EmployeeAddTest()
        {
            //arrenge
            string args = "MaksEngine|200|12|";
            string post = "e";
            Server.Server.employees = new List<IEmployees>();

            //act
            Server.Server.AddEmp(args, post);

            //assert
            Assert.AreEqual(1, Server.Server.employees.Count());
        }

        [TestMethod]
        public void EmployeeCheckSalaryTest()
        {
            //arrenge
            Server.Server.employees = new List<IEmployees>();
            double es = 300;
            double eh = 8;
            Engineer e = new Engineer("EngineerTest", es, eh, 0.87);

            double pi = 10;
            double pp = 500;
            Porter p = new Porter("PorterTest", 0, 0, 0.87);
            p.AddItem(pi);
            p.SetItemPrice(pp);

            double mcp = 88500.00;
            double mce = 0.30;
            Manager m = new Manager("ManagerTest", 0, 0, 0.87);
            m.AddContract(mce, mcp);

            Server.Server.employees.Add(e);
            Server.Server.employees.Add(m);
            Server.Server.employees.Add(p);

            //act
            string sal1 = Server.Server.GetEmpSal("0|1|2");
            string sal2 = Server.Server.GetEmpSal("0|2");
            string sal3 = Server.Server.GetEmpSal("1");

            string tsal1 = Convert.ToString(es*eh*0.87)+ "|" + Convert.ToString(mcp * mce * 0.87) + "|" + Convert.ToString(pi * pp * 0.87) + "|";
            string tsal2 = Convert.ToString(es*eh*0.87)+ "|" + Convert.ToString(pi * pp * 0.87) + "|";
            string tsal3 = Convert.ToString(mcp * mce * 0.87) + "|";

            //assert
            Assert.AreEqual(tsal1, sal1);
            Assert.AreEqual(tsal2, sal2);
            Assert.AreEqual(tsal3, sal3);
        }

        [TestMethod]
        public void EmployeeDelTest()
        {
            //arrenge
            Server.Server.employees = new List<IEmployees>();
            Server.Server.employees.Add(new Engineer("Engineer", 100.00, 12.00, 0.87));

            //assert
            Assert.AreEqual(1, Server.Server.employees.Count());

            //act
            Server.Server.DelEmp("0|");

            //assert
            Assert.AreEqual(0, Server.Server.employees.Count());

        }


        [TestMethod]
        public void GetListTest()
        {
            //arrenge
            string args = "MaksEngine|200|12|";
            string post = "e";
            Server.Server.employees = new List<IEmployees>();

            //act
            Server.Server.AddEmp(args, post);
            string list = Server.Server.GetEmpList();
            bool f = false;
            if(list.Length > 0) f = true;

            //assert
            Assert.AreEqual("[{\"Name\":\"MaksEngine\",\"Post\":\"Engineer\"}]", list);
            Assert.AreEqual(true, f);

        }
    }
}