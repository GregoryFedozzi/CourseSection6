using System;
using System.Globalization;
using System.Collections.Generic;

namespace CourseSection6
{
	class Program
	{
		static void Main(string[] args)
		{

			


			HashSet<int> A = new HashSet<int>();
			HashSet<int> B = new HashSet<int>();

			A.Add(3);
			A.Add(5);
			A.Add(8);
			A.Add(9);

			B.Add(3);
			B.Add(4);
			B.Add(5);

			A.UnionWith(B);


			foreach (int x in A)
			{
				Console.WriteLine(x);
			}

			Console.WriteLine("--------------");

			foreach (int x in B)
			{
				Console.WriteLine(x);
			}

			Console.WriteLine("--------------");

			int n = 4;

			if (A.Contains(n))
			{
				Console.WriteLine(n + " pertence ao conjunto B");
			}
			else
			{
				Console.WriteLine(n + " não pernte ao conjunto B");
			}

			Console.WriteLine("--------------");

			


			/*
			Console.WriteLine("How many employees will be registered");
			int n = int.Parse(Console.ReadLine());

			List<Employee> list = new List<Employee>();

			for (int i=1; i<= n; i++)
			{
				Console.WriteLine("Employee #" + i + ":");
				Console.Write("Id: ");
				int id = int.Parse(Console.ReadLine());
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("Salary: ");
				double salary = double.Parse(Console.ReadLine());
				list.Add(new Employee(id, name, salary));
				Console.WriteLine();
			}

			Console.WriteLine("Enter the employee id that will have salary increase : ");
			int searchId = int.Parse(Console.ReadLine());

			Employee emp = list.Find(x => x.Id == searchId);
			if (emp != null)
			{
				Console.WriteLine("Enter the percentage: ");
				double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				emp.IncreaseSalary(percentage);
			}
			else
			{
				Console.WriteLine("This is does not exist!");
			}

			Console.WriteLine();
			Console.WriteLine("Uptaded list od Employee");
			foreach (Employee odj in list)
			{
				Console.WriteLine(odj);
			}

















			
			/*
			Console.Write("How many rooms will be rented? ");
			int n = int.Parse(Console.ReadLine());

			int[] room = new int[9];
			Pessoa[] person = new Pessoa[n];

			for (int i = 0; i < n; i++)
			{
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("Email: ");
				string email = Console.ReadLine();
				Console.Write("Room number: ");
				int aux  = int.Parse(Console.ReadLine());

				person[i] = new Pessoa { Name = name, Email = email, Room = aux };
				room[aux] = aux;
			}

			for (int p = 0; p < room.Length; p++)
			{
				if (room[p] != null){
					Console.WriteLine("Rent ");
					Console.WriteLine("Name: " + person[p].Name);
					Console.WriteLine("Email: " + person[p].Email);
					Console.WriteLine("Room: " + person[p].Room);

				}
			}




			/*
			Console.Write("Digite a quantidade de produtos para registrar: ");
			int n = int.Parse(Console.ReadLine());

			Produto[] vect = new Produto[n];

			double tot = new double();

			for (int i = 0; i < n; i++)
			{
				Console.Write("Digite o nome do " + (i + 1) + "º produto ");
				string name = Console.ReadLine();
				Console.Write("Digite o preço do " + (i + 1) + "º produto ");
				double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				vect[i] = new Produto { Name = name, Price = price };
				tot = vect[i].Price;
			}

			Console.WriteLine("AVERAGE PRICE = " + ( tot/n).ToString("F2", CultureInfo.InvariantCulture));



			
			Console.Write("Digite a quantidade de pessoas para realizar a leitura: ");
			int n = int.Parse(Console.ReadLine());
			double aux = new double();

			double[] vect = new double[n];

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Digite a altura da " + (i+1) + "º pessoa : ");
				vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				aux += vect[i];
			}

			Console.WriteLine("A média das alturas é " + (aux/n).ToString("F2", CultureInfo.InvariantCulture));
			*/
		}
	}
}
