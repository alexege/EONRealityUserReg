using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EONRealityUserReg.Models
{
    public class User
    {
        [Key]
        [Display(Name = "No")]
        public int ID { get; set; }

        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public string Gender { get; set; }

        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Reg")]
        [Required]
        public DateTime DateRegistered { get; set; }

        [Display(Name = "Selected Days")]
        [Required]
        //public List<CheckboxModel> Days { get; set; }
        public string Days { get; set; }

        [Display(Name = "Add. request")]
        [StringLength(100)]
        public string Requests { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastModified { get; set; } = DateTime.Now;
    }

    //public class CheckboxModel
    //{
    //    [Key]
    //    public int DayId { get; set; }
    //    public string DayName { get; set; }
    //    public bool Selected { get; set; }

    //    public CheckboxModel()
    //    {

    //    }

    //    public CheckboxModel(int Id, string Name, bool isSelected)
    //    {
    //        this.DayId = Id;
    //        this.DayName = Name;
    //        this.Selected = isSelected;
    //    }
    //}
}