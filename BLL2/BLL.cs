using DTO2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL2

{
    public static class BLL
    {
        public static void AddBill(DTO2.models.Bill bill)
        {
            DAL2.Mappers.AddBill(bill);
        }

        public static List<DTO2.models.Bill> GetBiller()
        {
            return DAL2.Mappers.GetBiller();
        }

        public static Bill getBill(int id)
        {
            return DAL2.Mappers.GetBill(id);
        }
    }
}
