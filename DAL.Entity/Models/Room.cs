using System.ComponentModel.DataAnnotations;

namespace DAL.Entity.Models
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        public int RoomNum { get; set; }
        [Required]
        public int Floor { get; set; }
        [Required]
        public int Capacity { get; set; }
    }
}
