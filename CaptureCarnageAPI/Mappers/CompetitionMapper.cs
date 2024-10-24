using CaptureCarnageAPI.DTOs;
using CaptureCarnageAPI.Models;

namespace CaptureCarnageAPI.Mappers
{
    public static class CompetitionMapper
    {
        public static CompetitionDTO ToDTO(this Competition competition) => new CompetitionDTO
        {
            Id = competition.Id,
            Name = competition.Name,
            Description = competition.Description,
            StartDate = competition.StartDate,
            EndDate = competition.EndDate,
            Prizes = competition.Prizes
        };
    }
}
