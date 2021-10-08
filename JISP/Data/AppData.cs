using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JISP.Data
{
    public static class AppData
    {
        public static Ds Ds { get; private set; } = new Ds();

        public static string AppName { get => "JISP"; }
    }
}
