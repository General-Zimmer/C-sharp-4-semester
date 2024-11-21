using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL2.DAL
{
    internal class Initializer : CreateDatabaseIfNotExists<DataofTheBase>
    {
        protected override void Seed(DataofTheBase context)
        {
            context.Biler.Add(new BLL2.models.Bill { id = 1, Name = "Audi", weight = 1500, diesel = true });
            context.Biler.Add(new BLL2.models.Bill { id = 2, Name = "BMW", weight = 1700, diesel = true });
            context.Biler.Add(new BLL2.models.Bill { id = 3, Name = "VOLVO", weight = 1200, diesel = false });
            context.SaveChanges();
        }

        private void dummy()
        {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }
    }
}
