using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedFastreact.Data.Models.Services
{
    interface ImedicineInventory
    {
        void AddDrug(Medicine medicine);
        List<Medicine> ViewInventory();
        void UpdateDrug(string DrugID, Medicine medicine );
        void DeleteDrug(string DrugID);
        Medicine GetMedicineById(int id);
    }
}
