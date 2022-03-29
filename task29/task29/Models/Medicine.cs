using System;
using System.Collections.Generic;
using System.Text;

namespace task29.Models
{
    class Medicine
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; } = false;

        public Medicine(string name, double price, int count)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Count = count;
        }


        public void sell() {
            Count--;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nPrice: {Price}\nCount: {Count}");
        }

    }
}
