using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(50)] // string alanlara karakter sınırı koymak için
        public string Name { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
