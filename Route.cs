using BRS.SupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS
{
    [Serializable]
    class Route : Record
    {
        private string origin;
        private string destination;

        public Route() : base()
        {
            origin = "";
            destination = "";
        }

        public Route(string origin, string destination)
        {
            this.origin = origin;
            this.destination = destination;
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public override bool addRecord()
        {
            //string query = "insert into routeTable (origin,destination) values ('" + origin + "', '" + destination + "')";
            //string message = "Route added Successfully";
            //bool isAdded = AccessDatabaseController.AddRecordToDb(query, message);
            Database.AddRoute(this);
            return true;
        }

        public override string ToString()
        {
            return origin + " to " + destination;
        }
    }
}