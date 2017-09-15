using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalProject
{
    class HospitalEmployee
    {
        //FIELDS
        protected string employeeName;
        protected float employeeNumber;
        //FIELDS
        protected string specialtyArea;

        //PROPERTIES
        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
            set { this.specialtyArea = value; }
        }

        //PROPERTIES
        public string Name
        {
            get { return this.employeeName; }
            set { this.employeeName = value; }
        }
        public float idNumber
        {
            get { return this.employeeNumber; }
            set { this.employeeNumber = value; }
        }

        //CONTRACTORS
        public HospitalEmployee()
        {

        }

        public HospitalEmployee(string employeeName, float employeeNumber)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
        }
        //METHOD
        public virtual void GetName()
        {
            Console.WriteLine("Enter your name.");
            employeeName = Console.ReadLine();
         
        }
    }
}
