using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProject
{
    class Doctor:HospitalEmployee  
    {
        ////FIELDS
        //protected string specialtyArea;

        ////PROPERTIES
        //public string SpecialtyArea
        //{
        //    get { return this.specialtyArea; }
        //    set { this.specialtyArea = value; }
        //}

        //CONTRACTORS
        public Doctor()
        {

        }
        public Doctor(string employeeName, float employeeNumber, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
        }

    }

}
