﻿using System;
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
    public partial class FrmMenu : Form
    {
        public string Name;
        public string RoomNumber;
        public string IDCard;
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblName.Text="欢迎"+Name+"光临";
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE);
        }
        private void PbState_Click(object sender, EventArgs e)
        {
            RoomStatusBusiness_layer roomStatusBusiness_Layer = new RoomStatusBusiness_layer();
            RoomSchedules roomSchedules = roomStatusBusiness_Layer.rooms(RoomNumber);
            FrmState frmState = new FrmState();
            frmState.roomNumber = roomSchedules.RoomNumber;
            frmState.roomStatus = roomSchedules.RoomStatus;
            frmState.roomType = roomSchedules.RoomType;
            frmState.floor = roomSchedules.Floor;
            frmState.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ReportBusinessLayerManager report = new ReportBusinessLayerManager();
            StatementOfAccount statement = report.Soa(IDCard);
            FrmReportForm frm = new FrmReportForm();

            frm.roomNumber = statement.RoomNumber;
            frm.IDCard = statement.IDCard;
            frm.money = statement.money;
            frm.Describe = statement.Describe;
            frm.SpendingTime = statement.SpendingTime;
            frm.TotalConsumption = statement.TotalConsumption;

        }
    } 
}
