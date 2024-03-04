using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

/************************************************************
 * Project      BacteriaRate                                *
 * Programmer   Earl Manuel                                 *
 * Date         11/24/2023                                  *
 * Description  Uses SQL statements to connect to a database*
 *              and retrieve the fields from the tblBacteria*
 *              table. Determines the rate of bacteria to   *
 *              increase to see if the total reaches 1 billion*
 *              before the 2 hours have passed. If this     *
 *              condition is true, the bacteria is live.    *
 ***********************************************************/


namespace BacteriaRate
{
    public partial class MainForm : Form
    {

        // Variables and constants

        string connString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source = Bacteria.accdb";
        DataTable dt = new DataTable();
        int recordCountInteger = 0;
        int positionInteger = 0;
        int bacteriaInteger = 0;
        int timeInteger = 0;
        int totalTimeInteger = 0;
        int hoursInteger = 0;
        int minutesInteger = 0;
        string timeString = "";
        string dataSourceString = "";

        const int MAX_NUMBER_INTEGER = 1000000000;


        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Connects to the database
            dt.TableName = "tblBacteria";
            dataSourceString = "SELECT * FROM tblBacteria";

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dataSourceString, connString);

            dataAdapter.Fill(dt);
            dataAdapter.Dispose();

            recordCountInteger = Int32.Parse(dt.Rows.Count.ToString());

            // MessageBox.Show("Count: " + recordCountInteger, "Hello", MessageBoxButtons.OK);

            // Displays the first record
            DetermineBacteriaRate();

        }

        private void DetermineBacteriaRate()
        {
            // Computes the Bacteria rate
            bacteriaInteger = Int32.Parse(dt.Rows[positionInteger]["BeginningRate"].ToString());
            timeInteger = Int32.Parse(dt.Rows[positionInteger]["Minutes"].ToString());

            totalTimeInteger = 0;

            while (bacteriaInteger < MAX_NUMBER_INTEGER)
            {
                bacteriaInteger *= 2;
                totalTimeInteger += timeInteger;
            }
            //TEMPOARAY LINE

            //totalTimeInteger = 120;

            if (totalTimeInteger < 120)
            {
                MessageLblBox.Text = "Virus Active!";
                MessageLblBox.ForeColor = Color.Red;
            }
            else
            {
                MessageLblBox.Text = "Virus Cured!";
                MessageLblBox.ForeColor = Color.Green;
            }

            //Computes the hours and minutes
            hoursInteger = totalTimeInteger / 60;
            minutesInteger = totalTimeInteger % 60;
            timeString = hoursInteger + " : " + minutesInteger.ToString("00");

            // Displays each record

            IdLblBox.Text = dt.Rows[positionInteger]["IdNo"].ToString();
            NameLblBox.Text = dt.Rows[positionInteger]["BacteriaName"].ToString();
            CountLblBox.Text = bacteriaInteger.ToString("N0");
            TimeLblBox.Text = timeString;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Advances to the nest record

            if (positionInteger < recordCountInteger - 1)
            {
                positionInteger += 1;
                DetermineBacteriaRate();
            }
            else
            {
                MessageBox.Show("All Records Read", "EOF", MessageBoxButtons.OK);
                NextButton.Enabled = false;
            }
        }
    }
}
