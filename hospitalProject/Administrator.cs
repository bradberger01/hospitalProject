using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProject
{
    class Administrator:HospitalEmployee
    {

        //FIELDS
        protected string department;

        //PROPERTIES
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        //CONTRACTORS
        Administrator()
        {

        }

        Administrator(string name, float employeeNumber, string department)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;

        }
    }
