using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GARBAGE.Context;

namespace GARBAGE.Models
{
    [Table("author")]
    public partial class AuthorModel
    {
        [Key]
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Birthday { get; set; }

        // typename ntext will generate a text field instead of varchar

        [Column(TypeName = "ntext")]
        public string? Description { get; set; }

        // tags for the author based on what genre of books they write for example
        [Column(TypeName = "ntext")]
        public string? Tags { get; set; }
        public virtual ImgModel? Img_id { get; set; }

        // the items the author has made
        public virtual ObservableCollection<ItemModel> Items { get; set; }

        // standard date and time the image was uploaded or changed
        public DateTime? CreatedAt { get; set; } = default(DateTime?);
        public DateTime? UpdatedAt { get; } = default(DateTime?);

        public void AddAuthor(AuthorModel author)
        {
            using (var context = new LibraryContext())
            {
                context.Authormodel.Add(author);

                context.SaveChanges();
            }
        }
    }
}