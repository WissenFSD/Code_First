using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_First.DMO
{
    // tablo adı verebilirsiniz.
    [Table("HumanResources")]
	public class HumanResource
	{
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(20)]
        // ? işareti alanın nullable olmasını sağlar
        public string? Lastname { get; set; }




    }
}
