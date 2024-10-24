using System;

namespace CaptureCarnageAPI.DTOs
{
    public class CompetitionDTO
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Prizes { get; set; }
    }
}
