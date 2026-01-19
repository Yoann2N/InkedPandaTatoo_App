using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InkedPandaTatoo_App.Models
{
    
        public class Artiste
    {
        public Artiste()
        {
        }
        public Artiste(int id, string profession, string style, string pseudo, string bio, string instagtram, string facebook, string banniereurl, string vignetteurl )
        {
            Id = id;
            Profession = profession;
            Style = style;
            Pseudo = pseudo;
            Bio = bio;
            Instagram = instagtram;
            Facebook = facebook;
            BanniereUrl = banniereurl;
            VignetteUrl = vignetteurl;
        }
        public int Id { get; set; }


        
        public string Profession { get; set; }

        
        public string Style { get; set; }

        public string? Pseudo { get; set; }

        public string? Bio { get; set; }

        public string? Instagram { get; set; }

        public string? Facebook { get; set; }

        public string? BanniereUrl { get; set; }

        public string? VignetteUrl { get; set; }

        public string? Css { get; set; }

        public DateTime CreatedAt { get; set; } 

        public DateTime UpdatedAt { get; set; } 

       
        [ForeignKey("User")]
        public int UserId { get; set; }

        public required User User { get; set; }
    }

}

