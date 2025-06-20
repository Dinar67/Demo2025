//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LatypovDinarDemo2025.Databases
{
    using System;
    using System.Collections.Generic;
    
    public partial class Material
    {
        public Material()
        {
            this.ProductMaterial = new HashSet<ProductMaterial>();
            this.SupplierMaterial = new HashSet<SupplierMaterial>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdMaterialType { get; set; }
        public Nullable<decimal> PricePerOne { get; set; }
        public Nullable<decimal> CountInStorage { get; set; }
        public Nullable<decimal> MinCount { get; set; }
        public Nullable<int> CountInPackage { get; set; }
        public Nullable<int> IdUnit { get; set; }
    
        public virtual MaterialType MaterialType { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<ProductMaterial> ProductMaterial { get; set; }
        public virtual ICollection<SupplierMaterial> SupplierMaterial { get; set; }



        public decimal OrderPrice
        {
            get
            {
                if(CountInStorage < MinCount)

                    //Округляем до целого (Мин количество - количсетво на складе)
                    //       /  кол-во в упаковке * (кол-во в упаковке * цена одного материала)
                    return (decimal)Math.Ceiling(((decimal)MinCount - (decimal)CountInStorage)
                                / (decimal)CountInPackage *
                           ((decimal)PricePerOne * (decimal)CountInPackage));
                else return 0;
            }
        }
    }
}
