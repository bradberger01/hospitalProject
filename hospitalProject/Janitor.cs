using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProject
{
    class Janitor:HospitalEmployee
    {
        //FIELDS
        protected string department;
        protected bool isSweeping;

        //PROPERTIES
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public bool IsSweeping
        {
            get { return this.isSweeping; }
            set { this.isSweeping = value; }
        }

        //CONTRACTORS
        Janitor()
        {

        }

        Janitor(string name, float employeeNumber, string department, bool isSweeping)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.isSweeping = isSweeping;
        }
    }
}
