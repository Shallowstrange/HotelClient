using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using System.Data.SqlClient;
using System.Data;

namespace HotelDAL
{
    public class RoomStatusDataLayer
    {
        DBHelper dB = new DBHelper();

        public List<RoomSchedules> Rooms(string roomNumber)
        {
            List<RoomSchedules> rooms = new List<RoomSchedules>();
            string Sql = "select a.RoomNumber,r.name,b.StatusName from RoomSchedules a inner join RoomTypeTable r on r.No = a.RoomTypeinner join RoomStatus b on b.No = a.RoomStatus where 1=1";

            SqlParameter[] sp = null;

            if (roomNumber != "")
            {
                Sql += " and a.RoomNumber like '%"+roomNumber+"%'";
            }

            DataTable dt = dB.GetTable(Sql, "a.RoomNumber", sp);

            foreach (DataRow item in dt.Rows)
            {
                RoomSchedules room = new RoomSchedules
                {
                    RoomNumber = item["a.RoomNumber"].ToString(),
                    RoomType=(RoomTypeTable)item["r.name"],
                    RoomStatus=(RoomStatus)item["b.StatusName"]
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
