using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    class DataRepository
    {
        public static string GetAll(string v)
        {
            return SimulatedDatabase.Load(v);
        }

        public static void SaveData(string data)
        {
            SimulatedDatabase.Save(data);
        }
    }
}
