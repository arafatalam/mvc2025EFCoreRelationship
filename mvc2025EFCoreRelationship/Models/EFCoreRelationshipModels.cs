using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc2025EFCoreRelationship.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string? ProductName { get; set; }

        [Required]
        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime? CreationDate { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category? Category { get; set; }
    }


    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID {  get; set; }

        [Required]
        [Display(Name ="Category Name")]
        public string? CategoryName { get; set; }


        [Display(Name = "Description")]
        public string? CategoryDescription { get; set; }


        //public Product? Product { get; set; }


        public virtual ICollection<Product>? Products { get; set; }

    }
}
