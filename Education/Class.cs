﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education {
	class Class {

		public string Name { get; set; }
		private string _Language; 
		/// <summary>
		/// Language accepts only csharp or java
		/// </summary>
		public string Language {
			get {
				return _Language;
			}
			set {
				if (value == "csharp" || value == "java") {
					_Language = value;
				}
			}
		}
		public string Code { get; set; }
		public int Capacity { get; set; }
		public Instructor Instructor { get; set; }
		public List<Student> Students = new List<Student>();
	}
}
