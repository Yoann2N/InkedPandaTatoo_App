using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InkedPandaTatoo_App.Models
{
    class User
    {
        public User()
        {
            
        }
        public User(int id, string nom, string email, string password, string prenom, string adresse, string codepostal, string ville, string telephone)
        {
            Id = id;
            Name = nom;
            Email = email;
            Password = password;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal = codepostal;
            Ville = ville;
            Telephone = telephone;

        }
        public int Id { get; set; }

       
        public string Name { get; set; }

       
        public string Email { get; set; }

        public DateTime? EmailVerifiedAt { get; set; }

        
        public string Password { get; set; }

        // Equivalent de rememberToken() (token de "remember me")
        public string? RememberToken { get; set; }

        public DateTime CreatedAt { get; set; } 

        public DateTime UpdatedAt { get; set; } 

        public string? Prenom { get; set; }

        public string? Adresse { get; set; }

        public string? CodePostal { get; set; }

        public string? Ville { get; set; }

        public string? Telephone { get; set; }
    }
}
