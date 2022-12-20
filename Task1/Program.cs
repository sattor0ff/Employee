Employee employee1 = new Employee(1, "ArdasheR", "Sattori", 2500);

System.Console.WriteLine();
System.Console.WriteLine(employee1.GetID());
System.Console.WriteLine(employee1.GetFirstName());
System.Console.WriteLine(employee1.GetLastName());
System.Console.WriteLine(employee1.GetSalary());
System.Console.WriteLine(employee1.GetName());
System.Console.WriteLine();

employee1.SetSalary(3000);

System.Console.Write("Annual Salary(for 12 months): ");
System.Console.WriteLine(employee1.GetAnnualSalary());
System.Console.WriteLine();

System.Console.WriteLine($"Salary raiced from {employee1.GetSalary()} to {employee1.RaiseSalary(10)}");
System.Console.WriteLine();

System.Console.WriteLine(employee1.ToString());
