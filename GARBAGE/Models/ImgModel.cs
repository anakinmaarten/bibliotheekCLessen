using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace NameSpace.Models
{
    [Table("img")]
    public partial class ImgModel
    {
        [Key]
        public int Id { get; set; }

        public string? FileName { get; set; }

        // standard date and time the image was uploaded or changed
        public DateTime? CreatedAt { get; set; } = default(DateTime?);
        public DateTime? UpdatedAt { get; } = default(DateTime?);
    }
}