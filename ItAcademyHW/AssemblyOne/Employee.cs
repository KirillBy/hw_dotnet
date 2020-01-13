using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    internal class EmployeeInternal
    {
        protected const int maxSalaryProtected = 3000;
        internal const int minSalaryInternal = 500;
        protected internal int salaryProtInternal;
        private protected string departmentPrivProt;
        private string firstNamePrivate;
        public void ChangeNamePublic(string fName)
        {
            firstNamePrivate = "";
            string.Concat(firstNamePrivate, fName);
        }
    }
    class NewEmployeeInternal : EmployeeInternal
    {
    }
    public class EmployeePublic
    {
        protected const int maxSalaryProtected = 3000;
        internal const int minSalaryInternal = 500;
        protected internal int salaryProtInternal;
        private protected string departmentPrivProt;
        private string firstNamePrivate;
        public void ChangeNamePublic(string fName)
        {
            firstNamePrivate = "";
            string.Concat(firstNamePrivate, fName);
        }
    }
    public class NewEmployeePublic : EmployeePublic
    {
    }
}
