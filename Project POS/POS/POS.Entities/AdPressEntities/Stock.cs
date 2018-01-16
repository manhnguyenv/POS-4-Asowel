// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6

using System.Collections.Generic;

#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace POS.Entities
{

    // Stock
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class Stock
    {
        public string StoId { get; set; } // igd_id (Primary key) (length: 10)
        public string APWarehouseId { get; set; }   // apwarehouse_id (length: 10)
        public string Name { get; set; } // name (length: 100)
        public int Group { get; set; } // igd_type (length: 100)
        public string BarterCode { get; set; }  // barter_code (length: max)
        public string BarterName { get; set; }  // barter_name (length: max)
        public string UnitIn { get; set; } // unit_in (length: 100)
        public string UnitOut { get; set; } // unit_out (length: 100)
        public decimal StandardPrice { get; set; } // standard_price
        public string Info { get; set; } // info (length: 500)
        public string Supplier { get; set; } // supplier (length: 500)
        public int Deleted { get; set; } // deleted

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<StockInDetails> StockInDetails { get; set; }

        public virtual System.Collections.Generic.ICollection<StockOutDetails> StockOutDetails { get; set; }

        // Foreign keys
        public virtual APWareHouse APWareHouse { get; set; }

        public Stock()
        {
            StockInDetails = new System.Collections.Generic.List<StockInDetails>();
            StockOutDetails = new List<StockOutDetails>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>