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

namespace HotelRegulator
{
    public partial class FrmMenu : Form
    {
        public string Name;
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblName.Text="欢迎"+Name+"光临";
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE);
        }
    } 
}
