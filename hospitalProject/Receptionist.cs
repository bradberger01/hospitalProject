using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProject
{
    class Receptionist:HospitalEmployee
    {

        //FIELDS
        protected string department;
        protected bool isOnPhone;

        //PROPERTIES
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public bool IsOnPhone
        {
            get { return this.isOnPhone; }
            set { this.isOnPhone = value; }
        }

        //CONTRACTORS
        Receptionist()
        {

        }

        Receptionist(string name, float employeeNumber, string department, bool isOnPhone)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.isOnPhone = isOnPhone;
        }
    }
}
