using System;

namespace CaptureCarnageAPI.Models
{
    public class Competition
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Prizes { get; set; }
        public bool IsActive { get; set; }
    }
}
