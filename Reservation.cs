using BRS.SupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS
{
    [Serializable]
    class Reservation : Record
    {
        private string name;
        private string email;
        private string cnic;
        private int busId;
        private string date;
        private int seatNum;

        public Reservation() : base()
        {
            name = "";
            email = "";
            cnic = "";
            busId = 0;
            date = "";
            seatNum = 0;
        }

        public Reservation(int id, string name, string email, string cnic, int busId,
            string date, int seatNum) : base(id)
        {
            this.name = name;
            this.email = email;
            this.cnic = cnic;
            this.busId = busId;
            this.date = date;
            this.seatNum = seatNum;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string CNIC
        {
            get { return cnic; }
            set { cnic = value; }
        }

        public int BusID
        {
            get { return busId; }
            set { busId = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        
        public int SeatNumber
        {
            get { return seatNum; }
            set { seatNum = value; }
        }

        public override bool addRecord()
        {
            //string query = "insert into reservationTable (passengerName,passengerEmail,passengerNic,busId,reservationDate,seatNo) values ('" + Name + "','" + Email + "','" + CNIC + "'," + BusID + ",'" + Date + "'," + SeatNumber + ")";
            //string message = "Reservation Done";
            //bool isAdded = AccessDatabaseController.AddRecordToDb(query, message);

            Database.AddReservation(this);
            return true;
        }
    }
}