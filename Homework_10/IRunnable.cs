using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_10 {
    interface IRunnable {
      double MaxSpeed { get; set; }
      double Speed { get; set; }
      void Run(double speed);

  }
}
