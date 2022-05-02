using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_10 {
  internal class ValuableWPClasses {
		public class Book : IValuableWP {
			double _value;

			public Book(double value) {
				_value = value;
			}

      public double Value { get { return _value * 1.1; } set { _value = value; } }

    }

		public class Picture : IValuableWP {
			double _value;

			public Picture(double value) {
				_value = value;
			}

			public double Value { get { return _value * 1.1; } set { _value = value; } }
		}

		public class Statue : IValuableWP {
			double _value;

			public Statue(double value) {
				_value = value;
			}

			public double Value { get { return _value * 1.1; } set { _value = value; } }
		}

		public class Rarity : IValuableWP {
			double _value;

			public Rarity(double value) {
				_value = value;
			}

			public double Value { get { return _value * 1.1; } set { _value = value; } }
		}
	}
}
