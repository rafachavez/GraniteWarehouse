using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteWarehouse.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public bool Available { get; set; }

        public string Image { get; set; }

        public string ShaderColor { get; set; }

        [Display(Name="Product Type")]
        public int ProductTypeId { get; set; } // this is going to be a FK in productTypes table

        //below, this is a way to link the tables if the tables already exist or if i want to override the standard behavior

        [ForeignKey("ProductTypeId")]
        public virtual ProductTypes ProductsTypes { get; set; } //we are assuming the table already exists

        [Display(Name = "Special Tag")]
        public int SpecialTagsId { get; set; } //same as above but for the SpecialTags table

        [ForeignKey("SpecialTagsId")]
        public virtual SpecialTags SpecialTags { get; set; } //we are assuming the table already exists

    }
}
