using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using SwissTransport;
using GMap.NET.WindowsForms.Markers;


namespace GUI
{
    public partial class Form1 : Form
    {
        Transport transport = new Transport();
        Coordinate coordinate = new Coordinate();

        public Form1()
        {
            InitializeComponent();
            
        }
        private void getStations(string text, ListBox listBox)
        {
            if (text.Length >= 3)
            {
                listBox.Items.Clear();
                Stations stations = transport.GetStations(text);
                foreach (Station station in stations.StationList)
                {
                    listBox.Items.Add(station.Name);
                    listBox.Visible = true;
                    listBox.BringToFront();
                }
            }
        }
        public string getTableFromDataGrid()
        {
            StringBuilder strTable = new StringBuilder();
            try
            {
                strTable.Append("<table border='1' cellpadding='0' cellspacing='0'>");
                strTable.Append("<tr>");
                foreach (DataGridViewColumn col in dgvAnzeige.Columns)
                {
                    strTable.AppendFormat("<th>{0}</th>", col.HeaderText);
                }
                strTable.Append("</tr>");
                for (int i = 0; i < dgvAnzeige.Rows.Count; i++)
                {
                    strTable.Append("<tr>");
                    foreach (DataGridViewCell cell in dgvAnzeige.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            strTable.AppendFormat("<td>{0}</td>", cell.Value.ToString());
                        }
                    }
                    strTable.Append("</tr>");
                }
                strTable.Append("</table>");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return strTable.ToString();
        }

        private void getGrid()
        {
            Transport transport = new Transport();
            Cursor.Current = Cursors.WaitCursor;
            
            DataTable dtt_connections = new DataTable();
            dtt_connections.Columns.Add("Datum");
            dtt_connections.Columns.Add("Von");
            dtt_connections.Columns.Add("Abfahrt");
            dtt_connections.Columns.Add("Nach");
            dtt_connections.Columns.Add("Ankunft");
            dtt_connections.Columns.Add("Gleis");

            //Abfrage
            Connections connections = transport.GetConnections(txtVon.Text, txtNach.Text, dtpDatum.Value.ToString("yyyy-MM-dd"), dtpTime.Text);

            //Jedes Resulatat zur Liste hinzufügen
            foreach (Connection connection in connections.ConnectionList)
            {
                dtt_connections.Rows.Add(Get_Date(connection.From.Departure), connection.From.Station.Name, Get_Time(connection.From.Departure), connection.To.Station.Name, Get_Time(connection.To.Arrival), connection.To.Platform);
            }

            dgvAnzeige.DataSource = dtt_connections;
            UseWaitCursor = false;
        }
        /*
        private void get2Grid()
        {
            DataTable dtt_routes = new DataTable();
            dtt_routes.Columns.Add("Zeit");
            dtt_routes.Columns.Add("Nach");
            dtt_routes.Columns.Add("Linie");

            //Definieren der Station für die Abfahrtstafel (Inhalt der Textbox wird übergeben)
            Station station = transport.GetStations(BTN_von_2.Text).StationList.First();
            StationBoardRoot departures = transport.GetStationBoard(station.Name, station.Id); //Beispiel für station.name ist Luzern, Beispiel für station.Id = 8505000

            foreach (StationBoard station_b in departures.Entries)
            {
                dtt_routes.Rows.Add(Get_Time(station_b.Stop.Departure.ToString()), station_b.To, (station_b.Category + " " + station_b.Number)); //Jede Linie die gefunden wird, wird hier durchgegangen
            }

            DTG_Verbindungen_2.DataSource = dtt_routes;
        }
        */
        private string Get_Date(string date1)
        {
            string date2 = date1.Remove(10);
            DateTime date3 = Convert.ToDateTime(date2);
            return date3.ToString("dd.MM.yyyy");
        }

        private string Get_Time(string time1) //Zeit kommt so 13:25:00 und die letzen 2 Stellen :00 werden hier gelöscht.
        {
            string time2 = time1.Remove(0, 11);
            time2 = time2.Remove(5);
            return time2;
        }

        
        private void Switch_txt(TextBox textBox1, TextBox textBox2)
        {
            string temp = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = temp;
        }

        

        private void txtVon_TextChanged(object sender, EventArgs e)
        {
            getStations(txtVon.Text, lstVon);
        }

        private void txtNach_TextChanged(object sender, EventArgs e)
        {
            getStations(txtNach.Text, lstNach);
        }

        private void lstVon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtVon.Text = lstVon.SelectedItem.ToString();
            btnVerbindungsuchen.Focus();
            lstVon.Visible = false;
        }

        private void lstNach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtNach.Text = lstNach.SelectedItem.ToString();
            btnVerbindungsuchen.Focus();
            lstNach.Visible = false;
        }

        private void btnVerbindungsuchen_Click(object sender, EventArgs e)
        {
            if (txtVon.Text != string.Empty)
            {
                getGrid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie zwei Orte ein!");
            }
        }
    }
}
