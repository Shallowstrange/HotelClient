using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRegulator
{
    public partial class FrmReportForm : Form
    {
        public string roomNumber;
        public string IDCard;
        public string TotalConsumption;
        public string money;
        public string SpendingTime;
        public string Describe;

        public FrmReportForm()
        {
            InitializeComponent();
        }

        private void FrmReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
