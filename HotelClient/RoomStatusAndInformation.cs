using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelModel;
using HotelBLL;

namespace HotelRegulator
{
    public partial class RoomStatusAndInformation : Form
    {
        private RoomStatusBusiness_layer room = new RoomStatusBusiness_layer();
        public RoomStatusAndInformation()
        {
            InitializeComponent();
        }

        private void Btnquery_Click(object sender, EventArgs e)
        {
            Kan();
        }

        public void Kan()
        {
            List<RoomSchedules> rooms = room.rooms(txtcha.Text);
            dgvshitu.DataSource = room;
        }

        private void RoomStatusAndInformation_Load(object sender, EventArgs e)
        {
            Kan();
        }
    }
}
