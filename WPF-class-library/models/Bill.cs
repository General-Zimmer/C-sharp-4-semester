using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.models
{
    public class Bill
    {
        public int BilID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int weight { get; set; }
        public bool diesel { get; set; }

        public Bill()
        {
            
        }

        public override string ToString()
        {
            return Name + " " + weight;
        }
    }
}
