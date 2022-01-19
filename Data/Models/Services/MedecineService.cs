using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MedFastreact.Data.Models.Services
{
    public static class MedecineService
    {
        static List<Medicine>drugs{ get; }
        static int nextId = 3;
        static MedecineService()
        {
            drugs = new List<Medicine>
            {
                new Medicine{   Id=1, name="advill",price=100, quantity=6}

            };
        }
        public static List<Medicine> GetAll() => Medicine;
    }
}
