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
    
    public partial class SupplierMaterial
    {
        public int Id { get; set; }
        public Nullable<int> IdMaterial { get; set; }
        public Nullable<int> IdSupplier { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
