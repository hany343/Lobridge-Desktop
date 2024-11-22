using System;
using System.Windows.Forms;

namespace LoBridge
{
    public partial class OutTruckhistory : Form
    {
        string tn = "";
        public OutTruckhistory(string tnum)
        {
            tn = tnum;
            InitializeComponent();
        }
        DataQuery dq = new DataQuery();
        private void OutTruckhistory_Load(object sender, EventArgs e)
        {
            string q = "SELECT      top(10)  Truck.Truck_number, Truck.Trailer_number, Lading_Out.F_weight, Lading_Out.F_wbridge, Lading_Out.F_Wdate, Lading_Out.Net_Weight, Lading_Out.S_weight"
            + " FROM Lading_Out INNER JOIN Truck ON Lading_Out.Truck_ID = Truck.Truck_ID"
            + " WHERE(Truck.Truck_number = N'" + tn + "')";
            dataGridView1.DataSource = dq.GetDataTable(q);
        }
    }
}
