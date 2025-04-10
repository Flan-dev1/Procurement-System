using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models
{
    public class EmployeeType
    {
        private string type;
        private int id;

        public void setType(string type)
        {
            this.type = type;
        }

        public void setID(int id)
        {
            this.id = id;
        }

        public string getType()
        {
            return type;
        }

        public int getID()
        {
            return id;
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int ID { get => id; set => id = value; }
    }
}
