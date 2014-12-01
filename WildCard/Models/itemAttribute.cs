namespace WildCard.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("itemAttribute")]
    public partial class itemAttribute
    {
        public int itemAttributeId { get; set; }

        public int itemId { get; set; }

        public int templateAttributeId { get; set; }

        [StringLength(50)]
        public string value { get; set; }

        public virtual item item { get; set; }

        public virtual templateAttribute templateAttribute { get; set; }
    }
}
