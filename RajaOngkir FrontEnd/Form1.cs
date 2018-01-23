using RajaOngkir_FrontEnd.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RajaOngkir_FrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateCourierList();
            cboAPIType.SelectedIndex = 0;
        }

        private void populateCourierList()
        {
            //add list of couriers
            IEnumerable<Courier> courierList = new List<Courier>()
            {
                new Courier("jne", "Jalur Nugraha Ekakurir"),
                new Courier("pos", "Pos Indonesia"),
                new Courier("tiki", "Tiki")
            };
            cboCourier.DataSource = courierList;
            cboCourier.DisplayMember = "Name";
            cboCourier.ValueMember = "Code";
        }
    }
}
