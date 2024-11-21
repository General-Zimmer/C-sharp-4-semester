using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL.DAL
{
    internal class Initializer : CreateDatabaseIfNotExists<Database>
    {
        protected override void Seed(Database context)
        {
            context.Biler.Add(new BLL.models.Bill { BilID = 1, Name = "Audi", weight = 1500, diesel = true });
            context.Biler.Add(new BLL.models.Bill { BilID = 2, Name = "BMW", weight = 1700, diesel = true });
            context.Biler.Add(new BLL.models.Bill { BilID = 3, Name = "VOLVO", weight = 1200, diesel = false });
            context.SaveChanges();
        }

        private void dummy()
        {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }
    }
}
