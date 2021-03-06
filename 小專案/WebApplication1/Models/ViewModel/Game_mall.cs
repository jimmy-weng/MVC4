using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.ViewModel
{
    public class Game_mall
    {
        [Key]
        [Display(Name = "遊戲編號")]
        [Required]
        public int Game_number { get; set; }
        [Display(Name = "遊戲名稱")]
        [Required]
        public string Game_name { get; set; }
        [Display(Name = "遊戲種類")]
        [Required]
        public string Game_category { get; set; }
        [Display(Name = "單價")]
        [Required]
        [DataType(DataType.Currency)]
        public int Unit_price { get; set; }

        public string str { get; set; }
        public List<Game_mall>  game {get;set;}
        public string name { get; set; }

    }
}
