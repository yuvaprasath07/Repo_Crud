using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class StudentInfoModel
    {
        [Key]
        public int StudentID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public int standard { get; set; }

    }
}