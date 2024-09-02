namespace UserManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("usersystem")]
    public partial class usersystem
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        public int? contact { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        public int aadharNo { get; set; }

        public int dob { get; set; }
    }
}
