using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IceCore.Models
{
    [Table("Subscriber")]
    public partial class Subscriber
    {
        [Key]
        [Column("SubscriberID")]
        public int SubscriberId { get; set; }
        
        [StringLength(50)]
        [Unicode(false)]
        [Required(ErrorMessage = "Valid Name Required")]
        [DataType(DataType.Text)]
        public string UserName { get; set; } = null!;
        
        [StringLength(25)]
        [Unicode(false)]
        [Required(ErrorMessage = "Valid Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [StringLength(35)]
        [Unicode(false)]
        [Required(ErrorMessage = "Valid Email Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [StringLength(70)]
        [Unicode(false)]
        [Required(ErrorMessage = "Valid Address Required")]
        [DataType(DataType.Text)]
        public string Address { get; set; } = null!;

        [StringLength(30)]
        [Unicode(false)]
        [Required(ErrorMessage = "Valid Ph Required")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } = null!;
    }
}
