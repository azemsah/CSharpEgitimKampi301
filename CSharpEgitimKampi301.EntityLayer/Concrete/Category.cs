using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}

// int x; olarak tanımlanırsa FIELD
// public int Y { get; set; } ; OLARAK TANIMLANIRSA PROPERTY
// METHOTD İÇİNDE DEĞİŞKEN TANIMLANIRSA VARIABLE OLUYOR AŞAĞIDAKİ GİBİ
// VOID TEST()
// {
// INT Z;
// }