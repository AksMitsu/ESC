using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using RestSharp;
using System.Text.Json.Nodes;

namespace Client
{
    public partial class EmployeeController : Form
    {

        TcpClient client = new TcpClient();

        StreamReader Reader = null;
        StreamWriter Writer = null;

        public EmployeeController()
        {
            InitializeComponent();
        }

        void TryConnect(int port = 7777, string host = "127.0.0.1")
        {
            try
            {
                client.Close();
                client = new TcpClient();
                client.Connect(host, port); //подключение клиента
                Reader = new StreamReader(client.GetStream());
                Writer = new StreamWriter(client.GetStream());
                tbConsole.Text += $"Клиент подключился по адресу: {host}:{port}.\r\n";
            }
            catch (Exception ex)
            {
                tbConsole.Text += ("Ошибка подключения: "+ex.Message+"\r\n");
            }
        }

        private void EmployeeController_Load(object sender, EventArgs e)
        {
            mtbAddress.Mask = "###\\.###\\.###\\.###";
            mtbAddress.ValidatingType = typeof(System.Net.IPAddress);
            mtbPort.Mask = @"0000\";
            mtbPort.ResetOnSpace = false;

            cbPosts.Items.Add("Engineer");
            cbPosts.Items.Add("Manager");
            cbPosts.Items.Add("Porter");

        }

        private void btnGetSalary_Click(object sender, EventArgs e)
        {
            try
            {
                //Отправляем комманду
                SendMessage(Writer, "1");
                string sb = "";
                for (int a = 0; a < EmployeesTable.RowCount; a++)
                {
                    if (EmployeesTable[0, a].Selected || EmployeesTable[1, a].Selected)
                        sb += a.ToString() + "|";
                }
                string[] ids = sb.Split('|');
                ids = ids.Where(x => x != "").ToArray(); ;

                //Отправляем id-шники 
                SendMessage(Writer, sb);
                // считываем ответ в виде строки
                string message = Reader.ReadLine();
                //Разбираем ответ и заполняем зарплаты
                string[] salarys = message.Split('|');
                salarys = salarys.Where(x => x != "").ToArray();
                int i = 0;
                foreach (string id in ids)
                {
                    EmployeesTable.Rows[Convert.ToInt32(id)].Cells[2].Value = salarys[i];
                    i++;
                }
            }
            catch (Exception ex)
            {
                tbConsole.Text += ("GetSalaryBTN: "+ex.Message + "\r\n");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int port = 7777;
            string address = "127.0.0.1";
            if (mtbPort.Text != "" && mtbAddress.Text.Replace(" ", "") != "...")
            {
                port = Convert.ToInt32(mtbPort.Text);
                address = mtbAddress.Text.Replace(" ", "");
            }
            TryConnect(port, address);
        }



        private async void btnGetList_Click(object sender, EventArgs e)
        {
            try
            {
                //Посылаем запрос
                SendMessage(Writer, "0");
                //Получаем ответ
                string message = Reader.ReadLine();
                if (string.IsNullOrEmpty(message)) return;

                //Парсим и заполняем таблицу
                JsonArray json = (JsonArray)JsonArray.Parse(message);
                EmployeesTable.Rows.Add();
                EmployeesTable.Rows.Clear();

               

                foreach (JsonObject res in json)
                {
                    EmployeesTable.Rows.Add(res["Name"], res["Post"]);
                    if (!cbPosts.Items.Contains(res["Post"]))
                    {
                        //cbPosts.Items.Add(res["Post"]);
                    }
                }
            }
            catch (Exception ex)
            {
                tbConsole.Text += ("btnList: "+ex.Message + "\r\n");
            }
        } 

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(tbSendRequest.Text == "clr")
            {
                tbConsole.Text = "";
            }
        }

        void SendMessage(StreamWriter writer, string message)
        {
            try
            {
               writer.WriteLine(message);
               writer.Flush();
            }
            catch (Exception ex)
            {
                tbConsole.Text += ("Send "+ex.Message + "\r\n");
            }

        }

        bool GetMessage(StreamReader reader, string message)
        {
            try
            {

                string str = reader.ReadLine();
                if (str.Equals("ERR") || string.IsNullOrEmpty(str))
                {
                    return false;
                }
                message = str;
                return true;

            }
            catch (Exception ex)
            {
                tbConsole.Text += ("GetMess: " + ex.Message + "\r\n");
                return false;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        void disconnect()
        {
            client.Close();
            client = new TcpClient();
            tbConsole.Text += "Клиент отключен от сервера...\r\n";
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                SendMessage(Writer, "2");
                string req = "";
                switch (cbPosts.Text)
                {
                    case "Engineer":
                        SendMessage(Writer, "e");
                        req += tbName.Text + "|";
                        req += mtbSalary.Text + "|";
                        req += mtbHours.Text + "|";
                        break;

                    case "Manager":
                        SendMessage(Writer, "m");
                        req += tbName.Text + "|";
                        req += mtbSalary.Text + "|";
                        req += mtbHours.Text + "|";
                        req += mtbContractPrice.Text + "|";
                        req += mtbContractPercent.Text + "|";
                        break;

                    case "Porter":
                        SendMessage(Writer, "p");
                        req += tbName.Text + "|";
                        req += mtbSalary.Text + "|";
                        req += mtbHours.Text + "|";
                        req += mtbItemsCount.Text + "|";
                        req += mtbItemPrice.Text + "|";
                        break;
                    default:
                        break;
                }
                SendMessage(Writer, req);
                //Получаем ответ
                string message = Reader.ReadLine();
                if (string.IsNullOrEmpty(message)) return;

                //Парсим и заполняем таблицу
                JsonArray json = (JsonArray)JsonArray.Parse(message);
                EmployeesTable.Rows.Add();
                EmployeesTable.Rows.Clear();



                foreach (JsonObject res in json)
                {
                    EmployeesTable.Rows.Add(res["Name"], res["Post"]);
                    if (!cbPosts.Items.Contains(res["Post"]))
                    {
                        //cbPosts.Items.Add(res["Post"]);
                    }
                }
            }
            catch (Exception ex)
            {
                tbConsole.Text += ("btnList: " + ex.Message + "\r\n");
            }
            
        }

        private void cbPosts_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void cbPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPosts.Text)
            {
                case "Engineer":
                    label5.Visible = false;
                    label6.Visible = false;
                    mtbItemPrice.Visible = false;
                    mtbItemsCount.Visible = false;

                    label7.Visible = false;
                    label8.Visible = false;
                    mtbContractPercent.Visible = false;
                    mtbContractPrice.Visible = false;
                    break;

                case "Manager":
                    label5.Visible = false;
                    label6.Visible = false;
                    mtbItemPrice.Visible = false;
                    mtbItemsCount.Visible = false;

                    label7.Visible = true;
                    label8.Visible = true;
                    mtbContractPercent.Visible = true;
                    mtbContractPrice.Visible = true;
                    break;

                case "Porter":

                    label5.Visible = true;
                    label6.Visible = true;
                    mtbItemPrice.Visible = true;
                    mtbItemsCount.Visible = true;

                    label7.Visible = false;
                    label8.Visible = false;
                    mtbContractPercent.Visible = false;
                    mtbContractPrice.Visible = false;
                    break;
            }
        }

        private void btnDelEmpl_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить выделенных работников?", "ВНИМАНИЕ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Отправляем комманду
                    SendMessage(Writer, "3");
                    string sb = "";
                    for (int a = 0; a < EmployeesTable.RowCount; a++)
                    {
                        if (EmployeesTable[0, a].Selected || EmployeesTable[1, a].Selected)
                            sb += a.ToString() + "|";
                    }
                    string[] ids = sb.Split('|');
                    ids = ids.Where(x => x != "").ToArray(); ;

                    //Отправляем id-шники 
                    SendMessage(Writer, sb);
                    string message = Reader.ReadLine();
                    if (string.IsNullOrEmpty(message)) return;

                    //Парсим и заполняем таблицу
                    JsonArray json = (JsonArray)JsonArray.Parse(message);
                    EmployeesTable.Rows.Add();
                    EmployeesTable.Rows.Clear();
                    foreach (JsonObject res in json)
                    {
                        EmployeesTable.Rows.Add(res["Name"], res["Post"]);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            catch (Exception ex)
            {
                tbConsole.Text += ("DelEmpBTN: " + ex.Message + "\r\n");
            }
        }
    }
}
