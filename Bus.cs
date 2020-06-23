using BRS.SupportClasses;
using System;

namespace BRS
{
    [Serializable]
    class Bus : Record
    {
        private bool ac;
        private int fare;
        private string deptTime;
        private string arrivTime;
        private string origin;
        private string destination;

        public Bus() : base()
        {
            ac = false;
            fare = 0;
            deptTime = "";
            arrivTime = "";
            origin = "";
            destination = "";
        }

        public Bus(int id, bool ac, int fare, string dt, string at,
            string orig, string dest) : base(id)
        {
            this.ac = ac;
            this.fare = fare;
            this.deptTime = dt;
            this.arrivTime = at;
            this.origin = orig;
            this.destination = dest;
        }

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public int Fare
        {
            get { return fare; }
            set { fare = value; }
        }

        public bool AC
        {
            get { return ac; }
            set { ac = value; }
        }

        public string DepartureTime
        {
            get { return deptTime; }
            set { deptTime = value; }
        }

        public string ArrivalTime
        {
            get { return arrivTime; }
            set { arrivTime = value; }
        }

        public override bool addRecord()
        {

            //            string query = "insert into busTable (ac,fare,departureTime,arrivalTime,origin,destination) values (" + AC + "," + fare + ",'" + deptTime + "','" + arrivTime + "','" + origin + "','" + destination + "')";
            //            string message = "Bus added Successfully";

            //            bool isAdded = AccessDatabaseController.AddRecordToDb(query, message);
            Database.AddBus(this);
            return true;
        }
    }
}
