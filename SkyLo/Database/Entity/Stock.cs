namespace SkyLo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock")]
    public partial class Stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Stock_Id { get; set; }

        [StringLength(100)]
        public string Stock_Name { get; set; }

        [StringLength(100)]
        public string Stock_Type { get; set; }

        public int? Stock_Level { get; set; }
    }
}
