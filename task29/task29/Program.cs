using System;
using task29.Exceptions;
using task29.Models;

namespace task29
{
    class Program
    {
        static void Main(string[] args)
        {
            Pharmacy ph1 = new Pharmacy(10);
            Medicine md1 = new Medicine("ferid", 15, 200);
            Medicine md2 = new Medicine("ilkin", 25, 100);
            try
            {
               
                ph1.AddMedicine(md1);
                ph1.AddMedicine(md2);
                
            }
            catch (MedicineAlreadyExistsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }


            foreach (var item in ph1.GetAllMedicines())
            {
                item.ShowInfo();
            }
        }
    }
}
