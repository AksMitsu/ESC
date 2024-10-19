using Server.Employees;
using Server.Employees.Posts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Server
{
    public class Server
    {

        public static List<IEmployees> employees = new List<IEmployees>(); //Список сотрудников

        //Сохранение JSON
        public static void SaveWorkers()
        {
            JsonArray json = new JsonArray();
            foreach (IEmployees employee in employees)
            {
                json.Add(employee.Serialize());
            }
            File.WriteAllText("Employees.json", json.ToJsonString());
        }
        //Загрузка из JSON
        public static void LoadWorkers()
        {
            employees.Clear();
            string str = File.ReadAllText("Employees.json");
            JsonArray jsonArr = (JsonArray)JsonArray.Parse(str);
            foreach (JsonObject jsonEl in jsonArr)
            {
                switch ((string)jsonEl["Post"])
                {
                    case "Manager":
                        employees.Add(new Manager(jsonEl));
                        break;
                    case "Engineer":
                        employees.Add(new Engineer(jsonEl));
                        break;
                    case "Porter":
                        employees.Add(new Porter(jsonEl));
                        break;
                    default:
                        Console.WriteLine("NotStated");
                        break;
                }
            }

        }

        static void Main(string[] args)
        {

        /*    //Тестовый инженер
            Engineer e = new Engineer("EngineerTest", 300, 8, 0.87);


            //Тестовый сдельщик
            Porter p = new Porter("PorterTest", 0, 0, 0.87);
            p.AddItem(10);
            p.SetItemPrice(500);


            //Тестовый руководитель
            Manager m = new Manager("ManagerTest", 0, 0, 0.87);
            m.AddContract(0.30, 88500.00);
*/

            //Добавление тестовых сотрудников
            /*employees.Add(e);
            employees.Add(m);
            employees.Add(p);
            SaveWorkers();*/


            LoadWorkers(); //Отгружаем сотрудников из JSON

            TcpListener tcpListener = new TcpListener(IPAddress.Any, 7777);
            List<TcpClient> clients = new List<TcpClient>();
            try
            {
                tcpListener.Start();
                Console.WriteLine("Сервер запущен...");
                while (true)
                {
                    // создаем новую задачу для обслуживания нового клиента
                    Task.Run(async () => await ServerWork(await tcpListener.AcceptTcpClientAsync()));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect(tcpListener, clients);
            }
        }

        //Обработка запросов клиентов
        public static async Task ServerWork(TcpClient tcpClient)
        {
            NetworkStream stream = tcpClient.GetStream();
            string ClientEndPoint = tcpClient.Client.RemoteEndPoint.ToString();
            Console.WriteLine($"Клиент {ClientEndPoint} подключился.");
            // создаем StreamReader для чтения данных
            StreamReader streamReader = new StreamReader(stream);
            // создаем StreamWriter для отправки данных
            StreamWriter streamWriter = new StreamWriter(stream);

            while (true)
            {
                try
                {
                    string response = streamReader.ReadLine();
                    Console.WriteLine($"{ClientEndPoint}:{response}");

                    switch (response)
                    {
                        case "0":
                            streamWriter.WriteLine(GetEmpList());
                            streamWriter.Flush();

                            break;
                        case "1":
                            string ids = streamReader.ReadLine();
                            streamWriter.WriteLine(GetEmpSal(ids));
                            streamWriter.Flush();

                            break;
                        case "2":
                            string post = streamReader.ReadLine();
                            string arg = streamReader.ReadLine();
                            AddEmp(arg, post);
                            streamWriter.WriteLine(GetEmpList());
                            streamWriter.Flush();
                           

                            break;
                        case "3":
                            string idstr = streamReader.ReadLine();
                            DelEmp(idstr);
                            streamWriter.WriteLine(GetEmpList());
                            streamWriter.Flush();

                            break;
                        case "TESTCONNECT":
                            streamWriter.WriteLine(("Соединение установлено!"));
                            streamWriter.Flush();
                            break;
                        case "END":
                            streamWriter.WriteLine(("Досвидания!"));
                            streamWriter.Flush();
                            Console.WriteLine($"Клиент {ClientEndPoint} отключился от сервера");
                            stream.Close();
                            tcpClient.Close();
                            break;
                        default:
                            streamWriter.WriteLine("ERR");
                            streamWriter.Flush();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    stream.Close();
                    tcpClient.Close();
                    Console.WriteLine($"Клиент {ClientEndPoint}: " + ex.Message);
                    break;
                }
            }

        }


        //Получить имена и должности работников
        public static string GetEmpList()
        {
            JsonArray Workers = new JsonArray();
            foreach (IEmployees employee in employees)
            {
                Workers.Add(employee.ToJson());
            }
            string resp = Workers.ToJsonString();
            return resp;
        }



        public static string GetEmpSal(string idstr)
        {
            string[] ids = idstr.Split('|');
            ids = ids.Where(x => x != "").ToArray();
            string Salarys = "";
            foreach (string id in ids)
            {
                int sid = Convert.ToInt32(id);
                Salarys += employees[sid].CalcTotalSalary().ToString() + "|";
            }
            return Salarys;
        }

        public static void DelEmp(string idStr)
        {
            string[] ids = idStr.Split('|');
            ids = ids.Where(x => x != "").ToArray();

            for (int i = ids.Length - 1; i >= 0; i--)
            {
                int sid = Convert.ToInt32(ids[i]);
                employees.RemoveAt(sid);
            }
            SaveWorkers();
        }



        public static async void AddEmp(string par, string post)
        {

            switch (post)
            {
                case "e":

                    string[] eng = new string[5];
                    eng = par.Split('|');
                    eng = eng.Where(x => x != "").ToArray();
                    employees.Add(new Engineer(eng[0], Convert.ToDouble(eng[1]), Convert.ToDouble(eng[2]), 0.87));

                    break;
                case "m":

                    string[] man = new string[5];
                    man = par.Split('|');
                    man = man.Where(x => x != "").ToArray();

                    Manager m = new Manager(man[0], Convert.ToDouble(man[1]), Convert.ToDouble(man[2]), 0.87);
                    m.AddContract(Convert.ToDouble(man[3]), Convert.ToDouble(man[4]) / 100); //price, %
                    employees.Add(m);

                    break;
                case "p":

                    string[] por = new string[5];
                    por = par.Split('|');
                    por = por.Where(x => x != "").ToArray();
                    Porter p = new Porter(por[0], Convert.ToDouble(por[1]), Convert.ToDouble(por[2]), 0.87);
                    p.AddItem(Convert.ToDouble(por[3]));
                    p.SetItemPrice(Convert.ToDouble(por[4]));
                    employees.Add(p);

                    break;
            }
            SaveWorkers();

        }


        //Выключить сервер
        public static void Disconnect(TcpListener tcpListener, List<TcpClient> clients)
        {
            foreach (var client in clients)
            {
                client.Close(); //отключение клиента
            }
            tcpListener.Stop(); //остановка сервера
        }

    }
}


