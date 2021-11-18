using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Category
    {
        [Key]
        public int Identity { get; set; }
        [Required]
        [MaxLength(30,ErrorMessage="Category name must be 10 characters or less"),MinLength(5)]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public override string ToString()
        {
            return Name;
        }

    }
}
