using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary.Model
{
    class Product
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Product name")]
        public string ProductName { get; set; }

        [Required]
        [DisplayName("Purchase date")]
        public DateTime PurchaseDate{ get; set; }
                [Required]
        [DisplayName("Guarantee expire date")]
        public DateTime GuaranteeExp { get; set; }
                [Required]
        [DisplayName("Purchase date")]
        public DateTime WarrantyExp{ get; set; }

        [DisplayName("Age")]
        public int Alder { get; set; }


        [DisplayName("Zipcode")]
        public int ZipCode { get; set; }
    }
}
