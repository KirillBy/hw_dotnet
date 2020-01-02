using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeInternal employeeInternal = new EmployeeInternal();
            NewEmployeeInternal newEmployeeInternal = new NewEmployeeInternal();
            EmployeePublic employeePublic = new EmployeePublic();
            NewEmployeePublic newEmployeePublic = new NewEmployeePublic();
            employeeInternal.salaryProtInternal = 1000; //this element avalible here as protected internal
            employeeInternal.ChangeNamePublic("SomeName"); //this method avalible here as protected internal
            employeePublic.ChangeNamePublic("SomeName"); //this method avalible here as protected internal
            employeePublic.salaryProtInternal = 1000; //this element avalible here as protected internal
            newEmployeeInternal.salaryProtInternal = 1000; //this element avalible here as protected internal
            newEmployeeInternal.ChangeNamePublic("SomeName"); //this method avalible here as protected internal
            newEmployeePublic.salaryProtInternal = 1000; //this element avalible here as protected internal
            newEmployeePublic.ChangeNamePublic("SomeName"); //this method avalible here as protected internal
        }
    }
}
