using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CourseSection6
{
	class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Double Salary { get; set; }

		public Employee(int id, string name, double salary)
		{
			Id = id;
			Name = name;
			Salary = salary;
		}

		public void IncreaseSalary(double percentage)
		{
			Salary += Salary * percentage / 100.0;
		}

		public override string ToString()
		{
			return "Id: "
				+ Id
				+ "Name: "
				+ Name
				+ "Salary: "
				+ Salary.ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
