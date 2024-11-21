using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL2;
using DAL2.DAL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL2
{
    public static class Mappers
    {

        public static DTO2.models.Bill GetBill(int id)
        {
            DataofTheBase db = new DataofTheBase();
            var bill = db.Biler.Find(id);
            return new DTO2.models.Bill()
            {
                id = bill.id,
                Name = bill.Name,
                weight = bill.weight,
                diesel = bill.diesel
            };
        }

        public static List<DTO2.models.Bill> GetBiller()
        {
            DataofTheBase db = new DataofTheBase();
            var bill = db.Biler.ToList();
            List<DTO2.models.Bill> biller = new List<DTO2.models.Bill>();
            foreach (var b in bill)
            {
                biller.Add(new DTO2.models.Bill()
                {
                    id = b.id,
                    Name = b.Name,
                    weight = b.weight,
                    diesel = b.diesel
                });
            }
            return biller;
        }

        public static void AddBill(DTO2.models.Bill bill)
        {
            DataofTheBase db = new DataofTheBase();
            db.Biler.Add(new DAL2.models.Bill()
            {
                id = bill.id,
                Name = bill.Name,
                weight = bill.weight,
                diesel = bill.diesel
            });
            db.SaveChanges();
        }
    }
}
