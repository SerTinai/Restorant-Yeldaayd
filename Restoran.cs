using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeldaaydProject
{	public class Restoran
	{
		public string restoranName;
		public int chairNumber;
		public Restoran() 
		{
			chairNumber = 16;
		}
		public string MessagePrint()
		{
			return $"it is Restoran Name: {restoranName} and chair number: {chairNumber} ";
		}
	}
}
