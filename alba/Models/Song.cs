using System.ComponentModel.DataAnnotations;

namespace alba.Models
{
    public class Song : EntityBase
    {
        public Song(string name, int duration) :base()
        {
            Name = name;
            DurationSecs = duration;
        }
        [Required]
        public string Name { get; set; }
        [Required]
        public int DurationSecs { get; set; }
    }
}
