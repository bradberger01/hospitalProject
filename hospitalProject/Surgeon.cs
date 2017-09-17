using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProject
{
    class Surgeon:HospitalEmployee
    {
        //FIELDS
        protected string specialtyArea;
        protected bool working;

        //PROPERTIES
        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
            set { this.specialtyArea = value; }
        }

        public bool Working
        {
            get { return this.working; }
            set { this.working = value; }
        }

        //CONTRACTORS
        public Surgeon()
        {

        }
        public Surgeon(string employeeName, float employeeNumber, string specialtyArea, bool working)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.working = working;
        }
    }
}
