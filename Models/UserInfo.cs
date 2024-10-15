using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad alanı zorunlu.")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Telefon numarası zorunlu.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="Email adresi girilmesi zorunlu.")]
        [EmailAddress(ErrorMessage ="Geçerli bir email giriniz.")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Bir seçim yapmalısınız.")]
        
        public bool? WillAttend { get; set; }
    }
}