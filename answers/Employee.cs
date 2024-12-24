using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answers
{
    public enum EmployeeSecurityPrivilege
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }
    internal class Employee
    {

        #region attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeeSecurityPrivilege SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        private char _gender;
        #endregion

        public char Gender
        {
            get { return _gender; }
            set
            {
                if (value == 'M' || value == 'F')
                {
                    _gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be either 'M' (Male) or 'F' (Female).");
                }
            }
        }


        #region constructor
        public Employee(int _id, string _name, EmployeeSecurityPrivilege _securityLevel, decimal _salary, HiringDate _hireDate, char _gender)
        {

            Id = _id;
            Name = _name;
            SecurityLevel = _securityLevel;
            Salary = _salary;
            HireDate = _hireDate;
            Gender = _gender;
        }
        #endregion

        #region method
        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1}, Security Level: {2}, Salary: {3:C}, Hire Date: {4:d}, Gender: {5}",
                             Id, Name, SecurityLevel, Salary, HireDate, Gender);
        }
        #endregion
    }
}
