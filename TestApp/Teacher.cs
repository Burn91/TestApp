using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
	{
	class Teacher
		{

		public string FistName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public override string ToString()
			{
			return $"{FistName}, {LastName}, {Age}";
			}

		}
	}
