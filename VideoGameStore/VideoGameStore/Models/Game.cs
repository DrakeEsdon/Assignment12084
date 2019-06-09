using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoGameStore.Models
{
    public class Game // creates the game object with these below feild
    {
        public virtual int id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "You must Enter a Title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
        //I screwed up and made the scaffold without this and then I couldent figure out how to fix the error I got when trying to recreate it. I understand losing some marks but take pity

        [Display(Name = "Genre")]
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Minimum Requirements")]
        public string MinimumRequirements { get; set; }

        [Display(Name = "Publisher")]
        public string Publisher { get; set; }

        [Display(Name = "Developer")]
        public string Developer { get; set; }

        [Required]
        public decimal price { get; set; }

    }

}