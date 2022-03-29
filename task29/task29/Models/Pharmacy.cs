using System;
using System.Collections.Generic;
using System.Text;
using task29.Exceptions;

namespace task29.Models
{
    class Pharmacy
    {
        public int MedicineLimit { get; set; }

        private List<Medicine> _medicines ;

        public Pharmacy(int medicineLimit) 
        {
            MedicineLimit = medicineLimit;
            _medicines = new List<Medicine>();
        }
        

        public void AddMedicine(Medicine medicine)
        {
            if(_medicines.Count > MedicineLimit)
            {
                throw new CapacityLimitException("Limiti kecdiz.");
                return;
            }

            foreach (var item in _medicines)
            {
                if(item == medicine)
                {
                    throw new MedicineAlreadyExistsException("Bu Medicine bazada movcuddur.");
                    return;
                }
            }

            _medicines.Add(medicine);
            
            
        }

        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> medicinesCopy = new List<Medicine>();

            medicinesCopy.AddRange(_medicines);

            return medicinesCopy;
        }

        public List<Medicine> FilterMedicinesByPrice(double minPrice, double MaxPrice)
        {
            return _medicines.FindAll(m => m.Price >= minPrice && m.Price <= MaxPrice);
        }


        public Medicine GetMedicineById(int? id)
        {
            if(id == null)
            {
                throw new NullReferenceException("id gonderin.");
            }

            Medicine medicine = _medicines.Find(m => m.Id == id);
            if (medicine == null)
            {
                throw new NotFoundException("Bele Medicine yoxdur.");
               
            }

            return medicine;
        }

        public void DeleteMedicineById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("Id gonderin.");

            Medicine employee = _medicines.Find(m => m.Id == id);
            if (employee == null)
                throw new NotFoundException("Bele Medicine yoxdur.");

            _medicines.Remove(employee);
        }

        public void EditMedicineEmail(int? id, string name)
        {
            if (id == null || string.IsNullOrWhiteSpace(name)) ;
            {
                throw new NullReferenceException("Id ve Ad bos ola bilmez");
                return;
            }

            Medicine medicine = _medicines.Find(m => m.Name == name && m.IsDeleted==false);
            if(medicine == null)
            {
                throw new NotFoundException("Bele medcine yoxdur.");
            }

            medicine.Name = name;

        }



    }
}
