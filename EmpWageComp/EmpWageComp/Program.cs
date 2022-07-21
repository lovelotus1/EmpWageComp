using EmpWageComputation;

Console.WriteLine("Welcome to Employee Wage Computation Program\n");
//Console.WriteLine("Dell".ToString());
//EmpAttendance Dell = new EmpAttendance("Dell", 10, 4, 20);
//Dell.GetMonthlyEmpWage();

//Console.WriteLine("HP".ToString());
//EmpAttendance HP = new EmpAttendance("HP", 20, 5, 20);
//HP.GetMonthlyEmpWage();

//Console.WriteLine("Lenovo".ToString());
//EmpAttendance Lenovo = new EmpAttendance("Lenovo", 30, 3, 30);
//Lenovo.GetMonthlyEmpWage();
EmpWageBuilderList empWageBuilder = new EmpWageBuilderList();
empWageBuilder.AddCompanyEmpWageToList("dell", 10, 4, 20);
empWageBuilder.AddCompanyEmpWageToList("HP", 20, 5, 20);
empWageBuilder.AddCompanyEmpWageToList("Lenovo", 30, 3, 30);
empWageBuilder.computeEmpWage();

Console.ReadLine();