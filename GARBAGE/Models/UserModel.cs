using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using GARBAGE.Models;
using static System.Net.Mime.MediaTypeNames;
using GARBAGE.Database;
using GARBAGE.Context;

namespace GARBAGE.Models // ‘NameSpace’ is jouw namespace. ‘.Models’ verwijst naar een folder in jouw project
{
    [Table("Users")] // Geeft aan in welke tabel jij de data wil hebben
    public partial class UserModel // Deze class moet partial zijn i.v.m. bovenstaande Table attribute
    {
        [Key] // Geeft aan dat dit de primary key is
        public int Id { get; set; }

        private string? _firstname;
        [StringLength(50)] // Dit genereerd een nvarchar van maximaal 50 tekens
        public string? FirstName
        {
            get => _lastname;
            set 
            { 
                _lastname = value;
            }
        }

        private string? _lastname;

        [StringLength(50)]
        public string? LastName
        {
            get => _lastname;
            set => _lastname = value;
        }

        //  role of the user, defined by integer
        public int Role { get; set; }

        // img id of the profile image
        public virtual ImgModel? Img_id { get; set; }

        // phonenumber of the user
        public int Phonenumber { get; set; }

        // location the user works at
        public string? Location { get; set; }

        // standard date and time the user was made
        public DateTime? CreatedAt { get; set; } = default(DateTime?);
        public DateTime? UpdatedAt { get;} = default(DateTime?);

        
        public void AddUser(UserModel user) 
        {

            using (var context = new MyDbContext())
            {
                context.Users.Add(user);

                context.SaveChanges();
            }
        }

    }
}