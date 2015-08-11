namespace SkyLo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockType")]
    public partial class StockType
    {
        [Key]
        [StringLength(100)]
        public string StockType_Code { get; set; }

        [StringLength(100)]
        public string StockType_Desc { get; set; }
    }
}
