using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_To_Employee_Computation_Program.FinalSolution
{
    public interface IComputeEmpWage
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMnth);
        void computeEmpWage();

        int getTotalWage(string company);
    }

}
