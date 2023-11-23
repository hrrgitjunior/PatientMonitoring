using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientsMonitoring
{
    public partial class Form1 : Form
    {
        private DataTable patientDT;
        string[] uniqueDate;
        public Form1()
        {
            InitializeComponent();
        }

        private void subjCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            //MessageBox.Show("Change ===" + cb.Text, "Info");
            // DataTable patientDT = PatientData.FetchDataBySubjAndDate(cb.Text, "");
            dateCB.Items.Clear();
            patientDT = PatientData.FetchDataBySubj(cb.Text);
            uniqueDate = PatientData.GetDistinctDate(patientDT);
            foreach (string d in uniqueDate)
                dateCB.Items.Add(d);
            patientsDataGrid.DataSource = patientDT;

        }

        private void dateCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string[] dateArr;
            if (cb.Text == "All")
            {
                dateArr = new string[cb.Items.Count - 1];
                for (int i = 0; i < cb.Items.Count - 1; i++)
                    dateArr[i] = cb.Items[i].ToString();
            }
            else dateArr = new string[1] { cb.Text };

            //MessageBox.Show("Change ===" + cb.Text, "Info");
            patientDT = PatientData.FetchDataBySubjAndDate(this.subjCB.Text, dateArr);
            patientsDataGrid.DataSource = patientDT;
            GeneratePlot();
        }

        private void GeneratePlot()
        {
            string[] dateArr;
            if (dateCB.Text == "All")
            {
                dateArr = new string[uniqueDate.Length - 1];
                for (int i = 0; i < uniqueDate.Length - 1; i++)
                    dateArr[i] = uniqueDate[i];
            } else dateArr = new string[1] { dateCB.Text };

            Dictionary<string, List<object>> dateTemperatureDict = PatientData.CreateJoinedTemperatureList(patientDT, dateArr);
            Plot plot = new Plot();
            plot.CreatePlotByDateTemperatureOfPatient(monitoringChart, dateTemperatureDict);

        }
        private void generateBtn_Click(object sender, EventArgs e)
        {
            /*            Dictionary<string, double[]> sensorDict = PatientData.CreateDictBySensorsAndTemperature(patientDT);
                        Plot plot = new Plot();
                        plot.CreatePlot(this.monitoringChart, sensorDict);*/
            GeneratePlot();
        }
    }
}
