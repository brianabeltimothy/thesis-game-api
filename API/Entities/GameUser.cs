using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class GameUser
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }    
    }
}