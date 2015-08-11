namespace SkyLo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Order_Id { get; set; }

        public DateTime? Order_Dt { get; set; }

        [StringLength(10)]
        public string Order_User { get; set; }

        [StringLength(10)]
        public string Order_Quantity { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Stock_Id { get; set; }
    }
}
