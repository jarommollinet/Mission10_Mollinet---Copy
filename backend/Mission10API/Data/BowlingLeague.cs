using System.ComponentModel.DataAnnotations;

namespace Mission10API.Data
{
    public class BowlingLeague
    {
        [Key]
        public int BowlerId { get; set; }
        public string BowlerName { get; set; }
        public string TeamName { get; set; }
        public string StreetAddress { get; set; }  
        public string City { get; set; }
        public string State {  get; set; }
        public string Zip {  get; set; }
        public string Phone { get; set; }

    }
}
