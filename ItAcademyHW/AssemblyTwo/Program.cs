using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeePublic employeePublic = new EmployeePublic();
            NewEmployeePublic newEmployeePublic = new NewEmployeePublic();
            employeePublic.ChangeNamePublic("SomeName"); //this method avalible here as protected internal
            newEmployeePublic.ChangeNamePublic("SomeName"); //this method avalible here as protected internal
        }
    }
}
