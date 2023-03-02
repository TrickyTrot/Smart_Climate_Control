using Castle.Windsor;
using Dash.cs;
using LibraryOfDash;
using Repository.Interfaces;
using Servise.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiWinForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

        }

        public void PortText_TextChanged(object sender, EventArgs e)
        {

        }
        public bool Disc_clik = true;
        public List<Indication> indicationList = new List<Indication>();
        private void DisconnectionButton_Click(object sender, EventArgs e)
        {
            Disc_clik = false;
            Cursor.Current = Cursors.WaitCursor;
            WindsorContainer container = Bootstrap.BuildContainer();
            IDevise_work_journalServise devise_Work_Journal = container.Resolve<IDevise_work_journalServise>();
            IIndicationServise indicationServise = container.Resolve<IIndicationServise>();
            serialPort.Close();
            Console.WriteLine("Порт закрыт!");
            PortChek1.Text = "Порт: ЗАКРЫТ";
            PortChek1.ForeColor = Color.Red;
            temIzm.Text = "...";
            humIzm.Text = "...";
            ligIzm.Text = "...";
            devise_Work_journal.End_time = DateTime.Now.ToLongTimeString();
            if (devise_Work_journal.Start_time != null) devise_Work_Journal.Create(devise_Work_journal);
            if (indicationList.Any())
            {
                indicationServise.CreateMultiple(indicationList);
                indicationList.Clear();
            }

            Disc_clik = true;

        }


        public static SerialPort serialPort = new SerialPort();
        public Devises_work_journal devise_Work_journal = new Devises_work_journal();
        private void ConnectionButten_Click(object sender, EventArgs e)
        {

            PortChek1.Text = "Порт: ИДЁТ ПОДКЛЮЧЕНИЕ";
            Cursor.Current = Cursors.WaitCursor;

            Console.WriteLine(PortText.Text);
            try
            {
                serialPort.PortName = (PortText.Text);
            }
            catch (Exception)
            {
                PortText.Text = "Введите другой порт!";
                PortChek1.Text = "Порт: ЗАКРЫТ!";
                Console.WriteLine("Операция прервана");
                return;   
            }
            serialPort.BaudRate = (115200);
            devise_Work_journal.Start_time = DateTime.Now.ToLongTimeString();
            devise_Work_journal.CreationDate = DateTime.Now.ToShortDateString();
            //while (Disc_clik)
            // {
            serialPort.DataReceived += SerialPort_DataReceived;
            try
            {
                serialPort.Open();
            }
            catch (ArgumentException)
            {
                PortText.Text = "Введите другой порт!";
                PortChek1.Text = "Порт: ЗАКРЫТ";
                Console.WriteLine("Операция прервана");
                return;    
            }
            serialPort.DiscardInBuffer();
            PortChek1.Text = "Порт: ПОДКЛЮЧЕН ";
            PortChek1.ForeColor = Color.Green;

        }



        private void TemperaturePlus_Click(object sender, EventArgs e)
        {
            if (int.Parse(temMin.Text) < 49)
            {
                if (int.Parse(temMin.Text) == int.Parse(temMax.Text)) temMax.Text = (int.Parse(temMax.Text) + 2).ToString();
                temMin.Text = (int.Parse(temMin.Text) + 1).ToString();
            }
        }

        private void TemperatureMinus_Click(object sender, EventArgs e)
        {
            if (int.Parse(temMin.Text) > 0) temMin.Text = (int.Parse(temMin.Text) - 1).ToString();
        }

        private void HumidityMinus_Click(object sender, EventArgs e)
        {
            if (int.Parse(humSet.Text) > 0) humSet.Text = (int.Parse(humSet.Text) - 1).ToString();
        }

        private void HumidityPlus_Click(object sender, EventArgs e)
        {
            if (int.Parse(humSet.Text) < 100) humSet.Text = (int.Parse(humSet.Text) + 1).ToString();
        }

        private void LightMinus_Click(object sender, EventArgs e)
        {
            if (int.Parse(ligSet.Text) > 0) ligSet.Text = (int.Parse(ligSet.Text) - 1).ToString();
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)  IndicationsChart.Series[i].Points.Clear();
            Cursor.Current = Cursors.WaitCursor;
            WindsorContainer container = Bootstrap.BuildContainer();
            IIndicationServise indicationServise = container.Resolve<IIndicationServise>();
            for (int j = 0; j < 3; j++)
            {
                List<Indication> indications = indicationServise.GetAll(x => x.Id_devise == j + 1).ToList();
                int limit = indications.Count - 21;
                for (int i = limit; i < indications.Count; i++)      
                    IndicationsChart.Series[j].Points.AddXY(indications[i].Time_indic, indications[i].Value);
            }
        }

        private void LightPlus_Click(object sender, EventArgs e)
        {
            if (int.Parse(ligSet.Text) < 100) ligSet.Text = (int.Parse(ligSet.Text) + 1).ToString();
        }

        private void TemperatureMinusMax_Click(object sender, EventArgs e)
        {
            if (int.Parse(temMax.Text) > 1)
            {
                if (int.Parse(temMin.Text) == int.Parse(temMax.Text)) temMin.Text = (int.Parse(temMin.Text) - 2).ToString();
                temMax.Text = (int.Parse(temMax.Text) - 1).ToString();
            }
        }

        private void TemperaturePlusMax_Click(object sender, EventArgs e)
        {
            if (int.Parse(temMax.Text) < 50) temMax.Text = (int.Parse(temMax.Text) + 1).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void DataBase_and_TextUpdate(byte[] values)
        {
            WindsorContainer container = Bootstrap.BuildContainer();
            IIndicationServise indicationServise = container.Resolve<IIndicationServise>();
            IDevise_work_journalServise devise_Work_JournalServise = container.Resolve<IDevise_work_journalServise>();
            Indication indication = new Indication()
            {
                CreationDate = DateTime.Now.ToShortDateString(),
                Time_indic = DateTime.Now.ToLongTimeString()
            };
            try
            {
                List<Devises_work_journal> _Work_Journals = devise_Work_JournalServise.GetAll(x => x.CreationDate == devise_Work_journal.CreationDate).ToList();
                indication.Id_rec = _Work_Journals.Max(t => t.Id) + 1;
            }
            catch (Exception)
            {
                List<Devises_work_journal> _Work_Journals = devise_Work_JournalServise.GetAll().ToList();
                indication.Id_rec = _Work_Journals.Count();
            }
            for (int i = 1; i < 4; i++)
            {
                indication.Id_devise = i;
                indication.Value = values[i];
                indicationServise.Create(indication);
            }
            temIzm.Invoke(new Action(() => temIzm.Text = values[1].ToString()));
            humIzm.Invoke(new Action(() => humIzm.Text = values[2].ToString()));
            ligIzm.Invoke(new Action(() => ligIzm.Text = values[3].ToString()));
            
            
        }


        public void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("Bytes Cath");
            byte[] values = new byte[4];
            int bytesCount = serialPort.BytesToRead;
            if (bytesCount == 4)
            {
                serialPort.Read(values, 0, bytesCount);
                serialPort.DiscardInBuffer();
                Console.WriteLine(values);
                DataBase_and_TextUpdate(values);

            }
            serialPort.DiscardOutBuffer();
            values[0] = byte.Parse(temMin.Text);
            values[1] = byte.Parse(temMax.Text);
            values[2] = byte.Parse(humSet.Text);
            values[3] = byte.Parse(ligSet.Text);
            serialPort.Write(values, 0, 4);
            serialPort.DiscardOutBuffer();

        }

        private void IndicationsChart_Click(object sender, EventArgs e)
        {

        }

        private void ClearChart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<3; i++)
            IndicationsChart.Series[i].Points.Clear();

        }

        private void LightText_Changed(object sender, EventArgs e)
        {
            if (Disc_clik)
            {
                byte[] values = { byte.Parse(temIzm.Text), byte.Parse(humIzm.Text), byte.Parse(ligIzm.Text) };
                for (int i = 0; i < 3; i++)
                {
                    IndicationsChart.Series[i].Points.AddXY(DateTime.Now.ToLongTimeString(), values[i]);
                    if (IndicationsChart.Series[2].Points.Any() && IndicationsChart.Series[2].Points.Count() > 20)
                    {
                        IndicationsChart.Series[i].Points.RemoveAt(0);
                    }
                }
            }
        }
    }
}
