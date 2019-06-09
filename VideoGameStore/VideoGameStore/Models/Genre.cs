using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//creates the genre object with variables required and an dditional one I added. I thought this look more appropriate for a video game store
namespace VideoGameStore.Models
{
    public class Genre // creates the Genre object with the feilds below
    {

        public virtual int id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public List<Game> Games { get; set; }
    }
}
