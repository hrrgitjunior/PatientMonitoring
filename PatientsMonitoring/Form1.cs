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
        public Form1()
        {
            InitializeComponent();
        }

        private void subjCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            //MessageBox.Show("Change ===" + cb.Text, "Info");
           // DataTable patientDT = PatientData.FetchDataBySubjAndDate(cb.Text, "");
            patientDT = PatientData.FetchDataBySubj(cb.Text);
            string[] uniqueDate = PatientData.GetDistinctDate(patientDT);
            foreach (string d in uniqueDate)
                dateCB.Items.Add(d);
            patientsDataGrid.DataSource = patientDT;

        }

        private void dateCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            
            //MessageBox.Show("Change ===" + cb.Text, "Info");
            patientDT = PatientData.FetchDataBySubjAndDate(this.subjCB.Text, cb.Text);
            patientsDataGrid.DataSource = patientDT;
            GeneratePlot();
        }

        private void GeneratePlot()
        {
            List<object> joinedTemperatureList = PatientData.CreateJoinedTemperatureList(patientDT);
            Plot plot = new Plot();
            plot.CreatePlotByJoinedTemperature(monitoringChart, joinedTemperatureList);

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
