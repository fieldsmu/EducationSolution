using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Program {
		static void Main(string[] args) {

			Instructor greg = new Instructor {
				Name = "Greg",
				Email = "gdoud@gmail.com",
				PhoneNumber = "513-444-4444",
				ExperienceInYears = 20,
				PrimaryLanguage = "csharp"
			};

			Class dotnetbc4 = new Class {
				Capacity = 16,
				Code = "DN4",
				Language = "csharp",
				Name = ".NET BootCamp 4",
				Instructor = greg
			};

			Student foster = new Student {
				Name = "Foster",
				Class = dotnetbc4,
				ContactInfo = "513-444-4444",
				FirstJob = null,
				Absences = 0
			};

			Student jboy = new Student {
				Name = "Jonathon",
				Class = dotnetbc4,
				ContactInfo = "513-444-4444",
				FirstJob = null,
				Absences = 0
			};

			dotnetbc4.Students.Add(foster);
			dotnetbc4.Students.Add(jboy);
		}
	}
}
