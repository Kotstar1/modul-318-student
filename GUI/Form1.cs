using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Net.Mail;
using System.Device.Location;


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

        #region Email
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

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                MessageBox.Show("Bitte geben Sie eine Email-Adresse ein!");
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("modul318.henry.walker@gmail.com");
                    mail.To.Add(new MailAddress(Convert.ToString(this.txtEmail)));
                    mail.Subject = "Fahrplan";
                    mail.Body = "Hallo, hier ein Fahrplan, den ich mit dir teilen wollte. ";
                    mail.Body += "<b>" + getTableFromDataGrid() + "</b>";
                    mail.IsBodyHtml = true;
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("modul318.henry.walker@gmail.com", "Kennwort$11");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Email wurde erfolgreich gesendet");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        #endregion

        #region getGrid Fahrplan
        private void getGrid()
        {

            Cursor.Current = Cursors.WaitCursor;
            DataTable dtConnections = new DataTable();
            dtConnections.Columns.Add("Datum");
            dtConnections.Columns.Add("Von");
            dtConnections.Columns.Add("Nach");
            dtConnections.Columns.Add("Abfahrt");
            dtConnections.Columns.Add("Ankunft");
            dtConnections.Columns.Add("Gleis");

            //Abfrage
            Connections connections = transport.GetConnections(txtVon.Text, txtNach.Text, dtpDatum.Value.ToString("yyyy-MM-dd"), dtpTime.Text);

            //Jedes Resulatat zur Liste hinzufügen
            foreach (Connection connection in connections.ConnectionList)
            {
                dtConnections.Rows.Add(getDate(connection.From.Departure), connection.From.Station.Name, connection.To.Station.Name, getTime(connection.From.Departure), getTime(connection.To.Arrival), connection.To.Platform);
            }

            dgvAnzeige.DataSource = dtConnections;
            UseWaitCursor = false;
        }


        #endregion


        #region GoogleMaps
        private void Create_GmapStation(string x, string y)
        {
            string url = "https://www.google.ch/maps/place/" + x + "," + y;
            webGoogleMaps.Navigate(url);
        }

        private void btnGooglemaps_Click(object sender, EventArgs e)
        {


            if (txtVon.Text != string.Empty)
            {
                Stations stations = transport.GetStations(txtVon.Text);
                Station station = stations.StationList[0];
                Create_GmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein!");
            }
        }
        #endregion

        #region getGrid Abfahrtstafel
        private void getGridAbfahrtstafel()
        {
            DataTable dtt_routes = new DataTable();
            dtt_routes.Columns.Add("Zeit");
            dtt_routes.Columns.Add("Nach");
            dtt_routes.Columns.Add("Linie");

            //Definieren der Station für die Abfahrtstafel (Inhalt der Textbox wird übergeben)
            Station station = transport.GetStations(txtStation.Text).StationList.First();
            StationBoardRoot departures = transport.GetStationBoard(station.Name, station.Id); //Beispiel für station.name ist Luzern, Beispiel für station.Id = 8505000

            foreach (StationBoard station_b in departures.Entries)
            {
                dtt_routes.Rows.Add(getTime(station_b.Stop.Departure.ToString()), station_b.To, (station_b.Category + " " + station_b.Number)); //Jede Linie die gefunden wird, wird hier durchgegangen
            }

            dgvAbfahrtstafel.DataSource = dtt_routes;
        }


        #endregion

        #region getDate/getTime/getStations
        private string getDate(string date1)
        {
            string date2 = date1.Remove(10);
            DateTime date3 = Convert.ToDateTime(date2);
            return date3.ToString("dd.MM.yyyy");
        }

        private string getTime(string time1) //Zeit kommt so 13:25:00 und die letzen 2 Stellen :00 werden hier gelöscht.
        {
            string time2 = time1.Remove(0, 11);
            time2 = time2.Remove(5);
            return time2;
        }
        private void getStations(string text, ListBox listBox)
        {
            if (text.Length >= 2)
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
        #endregion

        #region Switch Text
        private void Switch_txt(TextBox textBox1, TextBox textBox2)
        {
            string temp = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = temp;
        }
        private void pbSwitch_Click(object sender, EventArgs e)
        {
            Switch_txt(txtVon, txtNach);
            lstVon.Visible = false;
            lstNach.Visible = false;
        }

        #endregion



        #region Fahrplan Objekte 

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

        private void lstVon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    txtVon.Text = lstVon.SelectedItem.ToString();
                    txtNach.Focus();
                    lstVon.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Wählen Sie eine Station aus");
                }

            }
        }

        private void lstNach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    txtNach.Text = lstNach.SelectedItem.ToString();
                    dtpDatum.Focus();
                    lstNach.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Wählen Sie eine Station aus");
                }

            }
        }
        #endregion

        #region Navigation
        private void btnNavfahrplan_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelnav.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void btnNavAbfahrtstafel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panelnav.Visible = true;
        }
        #endregion

        #region Abfahrtstafel Objekte
        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            if (txtStation.Text != string.Empty)
            {
                getGridAbfahrtstafel();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Orte ein!");
            }
        }

        private void txtStation_TextChanged(object sender, EventArgs e)
        {
            getStations(txtStation.Text, lstStation);
        }

        private void lstStation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtStation.Text = lstStation.SelectedItem.ToString();
            btnAbfahrtstafel.Focus();
            lstStation.Visible = false;
        }



        private void lstStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    txtStation.Text = lstStation.SelectedItem.ToString();
                    btnAbfahrtstafel.Focus();
                    lstStation.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Wählen Sie eine Station aus");
                }

            }
        }


        #endregion

        private void txtVon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lstVon.Focus();
                
            }
        }

        private void txtNach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lstNach.Focus();
            }
        }

        #region Geowatcher
        private void Form1_Load(object sender, EventArgs e)
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            watcher.PositionChanged += watcher_PositionChanged;
            watcher.Start();
        }

        private void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            MessageBox.Show(String.Format("Lat: {0}, Long: {1}", e.Position.Location.Latitude,
                e.Position.Location.Latitude));
        }

        private void getGridGeoWatcher()
        {

            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            watcher.PositionChanged += watcher_PositionChanged;
            watcher.Start();/*
                Stations stations = transport.GetStations(Convert.ToString(watcher));
                Station station = stations.StationList[0];
                Create_GmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;*/
            DataTable dtt_routes = new DataTable();
            dtt_routes.Columns.Add("Zeit");
            dtt_routes.Columns.Add("Nach");
            dtt_routes.Columns.Add("Linie");

            //Definieren der Station für die Abfahrtstafel (Inhalt der Textbox wird übergeben)
            Stations stations = transport.GetStations(Convert.ToString(watcher));
            Station station = stations.StationList[0];
            StationBoardRoot departures = transport.GetStationBoard(Convert.ToString(station.Coordinate.XCoordinate), Convert.ToString(station.Coordinate.YCoordinate)); //Beispiel für station.name ist Luzern, Beispiel für station.Id = 8505000

            foreach (StationBoard station_b in departures.Entries)
            {
                dtt_routes.Rows.Add(getTime(station_b.Stop.Departure.ToString()), station_b.To, (station_b.Category + " " + station_b.Number)); //Jede Linie die gefunden wird, wird hier durchgegangen
            }

            dgvAbfahrtstafel.DataSource = dtt_routes;





        }



        private void btnNavGooglemaps_Click(object sender, EventArgs e)
        {
            getGridGeoWatcher();
        }


        #endregion


    }
}
