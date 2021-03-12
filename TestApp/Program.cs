using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
	{
	class Program
		{
		static void Main( string[] args )
			{
			Teacher _teacher = new Teacher();

			_teacher.FistName = "Franz";
			_teacher.LastName = "Schütz";
			_teacher.Age = 55;

			_teacher.ToString();
			Console.Read();
			}
		}
	}
