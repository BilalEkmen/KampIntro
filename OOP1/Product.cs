using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //just property (özellik)
    { 
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //birim fiyatı
        public double UnitPrice { get; set; }
        //stok adedi
        public int UnitInStock { get; set; }


        // CRUD = Create - Reade - Update - Delete   



    }
}
