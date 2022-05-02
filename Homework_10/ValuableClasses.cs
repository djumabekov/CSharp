using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_10 {
  internal class ValuableClasses {
		public class Book : IValuable {
			double _value;

			public Book(double value) {
				_value = value;
			}

			public double GetValue() => _value * 1.1;
		}

		public class Picture : IValuable {
			double _value;

			public Picture(double value) {
				_value = value;
			}

			public double GetValue() => _value * 1.1;
		}

		public class Statue : IValuable {
			double _value;

			public Statue(double value) {
				_value = value;
			}

			public double GetValue() => _value * 1.1;
		}

		public class Rarity : IValuable {
			double _value;

			public Rarity(double value) {
				_value = value;
			}

			public double GetValue() => _value * 1.1;
		}
	}
}
