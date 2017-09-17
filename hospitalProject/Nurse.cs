using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProject
{
    class Nurse:HospitalEmployee
    {
        //FIELDS
        protected int numberOfPatients;

        //PROPERTIES
        public int NumberOfPatients
        {
            get { return this.numberOfPatients; }
            set { this.numberOfPatients = value; }
        }
       
        //CONTRACTORS
        Nurse()
        {

        }

        Nurse(string name, float employeeNumber, int numberOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.numberOfPatients = numberOfPatients;
        }
    }
}
