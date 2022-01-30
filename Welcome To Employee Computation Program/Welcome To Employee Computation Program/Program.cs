// See https://aka.ms/new-console-template for more information
using Welcome_To_Employee_Computation_Program;
using Welcome_To_Employee_Computation_Program.FinalSolution;
using Welcome_To_Employee_Computation_Program.ManageEmployeeWageMultiple;
using Welcome_To_Employee_Computation_Program.UC9_BuiderObject;

//EmployeeAttendance.GetAttendance();
//EmployeeWage.EmpWage();
//EmployeeWage.PartTimeEmpWage();
//EmployeeWage.EmpWageUsingSwitch();
//EmployeeWage.CalculateWageTill100HrsOr20IsReached();
//EmployeeWage.ComputeEmpWage();
EmployeeWage.ComputeEmpWage("DMart", 20, 2, 10);
//EmployeeWage.ComputeEmpWage("Reliance",10,4,20);

#region UC9
//EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
//EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
//dMart.computeEmpWage();
//Console.WriteLine(dMart.toString());
//reliance.computeEmpWage();
//Console.WriteLine(reliance.toString());
#endregion

#region UC10
//EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
//empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
//empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
//empWageBuilder.computeEmpWage();
#endregion

#region FinalSolution
//EmpWageBuilder empWageBuild = new EmpWageBuilder();
//empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
//empWageBuild.addCompanyEmpWage("Reliance", 10, 4, 20);
//empWageBuild.computeEmpWage();
#endregion

Console.ReadKey();
