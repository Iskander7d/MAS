using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MAS
{
    public partial class Form1 : Form
    {
        static private List<string> statuses = new List<string>
        { 
            "idle",             //0
            "atm queue",        //1
            "service queue",    //2
            "using atm",        //3
            "using service",    //4
            "complete"          //5
        };

        static private List<Client> clients = new List<Client> { };

        static private int ATMUsageLimit = 1;
        static private int ServiceUsageLimit = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Simulation()
        {

            int clientsTotal = 10;
            int iter = 0;
            Random rnd = new Random();
            while(clientsTotal > 0)
            {
                string name = String.Format("client {0}", iter);
                int operation = rnd.Next(0, 2);
                int operationTime = rnd.Next(2, 6);
                string status = (operation == 0) ? statuses[1] : statuses[2]; 
                Client client = new Client(name, operation, operationTime, status);
                clients.Add(client);
                clientsTotal--;
                iter++;

            }

            foreach (Client client in clients)
            {
                if (client.operation == 0)
                {
                    atm_queue.Rows.Add(client.name, client.operationTime);
                }
                else
                {
                    service_queue.Rows.Add(client.name, client.operationTime);
                }
            }

            ATM();
            Service();

        }

        async private void ATM()
        {
            foreach (Client client in clients.Where(c => c.operation == 0 && c.status == "atm queue"))
            {
                if (ATMUsageLimit > 0)
                {
                    atm_queue.Rows.RemoveAt(0);
                    atm_usage.Rows.Add(client.name, client.operationTime);
                    ATMUsageLimit--;
                    client.status = statuses[3];
                    int usageTime = client.operationTime;
                    while (usageTime > 0)
                    {
                        await Task.Delay(1000);
                        usageTime--;
                        atm_usage.Rows[0].Cells[1].Value = usageTime;
                    }
                    ATMUsageLimit++;
                    client.status = statuses[5];
                    atm_usage.Rows.RemoveAt(0);
                    atm_result.Rows.Add(client.name);
                }
            }
        }

        async private void Service()
        {
            List<int> operationTimes = new List<int> { };
            while (clients.Where(c => c.operation == 1 && c.status != "complete").Count() != 0)
            {
                foreach (Client client in clients.Where(c => c.operation == 1 && c.status != "complete"))
                {
                    if (client.status == "service queue")
                    {
                        if (ServiceUsageLimit > 0)
                        {
                            client.status = statuses[4];
                            ServiceUsageLimit--;
                        }
                    }

                    foreach (Client bClient in clients.Where(c => c.operation == 1 && c.status == "using service"))
                    {
                        if (bClient.operationTime > 0)
                        {
                            bClient.operationTime--;
                            string msg = bClient.name + " " + bClient.operationTime;
                            Trace.WriteLine(msg);
                        }
                        else
                        {
                            bClient.status = statuses[5];
                            service_result.Rows.Add(bClient.name);
                            ServiceUsageLimit++;
                            string msg = bClient.name + " " + bClient.status;
                            Trace.WriteLine(msg);
                        }

                    }
                    await Task.Delay(1000);
                }
            }

        }

        private void simulationBtn_Click(object sender, EventArgs e)
        {
            Simulation();
        }
    }

    public class Client
    {
        public Client(string name, int operation, int operationTime, string status)
        {
            this.name = name;
            this.operation = operation;
            this.operationTime = operationTime;
            this.status = status;
        }

        public string name { get; set; }

        public int operation { get; set; }
        public int operationTime { get; set; }

        public string status { get; set; }
    }
}
