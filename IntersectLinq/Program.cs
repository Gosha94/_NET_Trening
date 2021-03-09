using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<DcModel> SelectedDcs = new List<DcModel>()
            {
                new DcModel { Name = "РЦ 1"},
                new DcModel { Name = "РЦ 1"},
            };
            List<SkuModel> SelectedSkus = new List<SkuModel>()
            {
                new SkuModel {Name="Бананы 1 кг"},
                new SkuModel {Name="Авокадо синий"},
                new SkuModel {Name="Огурчик Рик"},
                new SkuModel {Name="Яблоко"},
            };

            var skuDcLinks = from dc in SelectedDcs
                         from sku in SelectedSkus
                         select new { Dc = dc.Name , Sku  = sku.Name};

            foreach (var link in skuDcLinks)
                Console.WriteLine($"{link.Dc} - {link.Sku}");

            Console.ReadLine();
        }
    }
    class DcModel
    {
        public string Name { get; set; }        
    }
    class SkuModel
    {
        public string Name { get; set; }        
    }
}
