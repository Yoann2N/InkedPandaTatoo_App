using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Text;

namespace InkedPandaTatoo_App.Models
{
    public class Realisation
    {
        public Realisation()
        {
        }
        public Realisation(int id, int artisteid, string titre, String description, string imageurl )
        {
            Id = id;
            ArtisteId = artisteid;
            Titre = titre;
            Description = description;
            ImageUrl = imageurl;
        }
        public int Id { get; set; }

        
        public int ArtisteId { get; set; }

        public Artiste Artiste { get; set; }

        
        public string? Titre { get; set; }

       
        public string? Description { get; set; }

        
        public string ImageUrl { get; set; }

        public DateTime CreatedAt { get; set; } 

        public DateTime UpdatedAt { get; set; } 
    }

}

