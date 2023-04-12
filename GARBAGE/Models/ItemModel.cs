using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.ObjectModel;

namespace NameSpace.Models
{
    [Table("item")]
    public partial class ItemModel
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        // typename ntext will generate a text field instead of varchar

        [Column(TypeName = "ntext")]
        public string? Description { get; set; }

        [Column(TypeName = "ntext")]
        public string? Summary { get; set; }

        public int Type { get; set; }

        [Column(TypeName = "ntext")]
        public string? Tags { get; set; }

        // length in minutes(if movie) or pages(if book)
        public int? Length { get; set; }

        public DateTime? ReleasedAt { get; set; }

        // the author(s) that made this item. Since multiple authors could have made this item, it's a collection.
        public virtual ObservableCollection<AuthorModel> Author { get; set; }

        // standard date and time the image was uploaded or changed
        public DateTime? CreatedAt { get; set; } = default(DateTime?);
        public DateTime? UpdatedAt { get; } = default(DateTime?);


    }
}