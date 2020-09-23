using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace AgeOfVillegrs 
{
	public class SaveVillage : ICommand
	{
		village village;
		public SaveVillage(village village)
		{
			this.village = village;
		}

	}
}
