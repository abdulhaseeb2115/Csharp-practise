using System.ComponentModel.DataAnnotations;

namespace AspPractise1.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string name { get; set; }



        public virtual Department dept { get; set; }
    }
}