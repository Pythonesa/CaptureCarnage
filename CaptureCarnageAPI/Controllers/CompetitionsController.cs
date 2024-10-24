using CaptureCarnageAPI.Contracts;
using CaptureCarnageAPI.DTOs;
using CaptureCarnageAPI.Mappers;
using CaptureCarnageAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CaptureCarnageAPI.Controllers
{
    [Route("competitions")]
    [ApiController]
    public class CompetitionsController : ControllerBase
    {
        private readonly ICompetitions repository;

        public CompetitionsController(ICompetitions repo)
        {
            repository = repo;
        }

        [HttpGet]
        public IEnumerable<CompetitionDTO> GetCompetitions() => (IEnumerable<CompetitionDTO>)repository.GetCompetitions().Select(c => c.ToDTO());
            
        


        [HttpGet("{id}")]
        public ActionResult<CompetitionDTO> GetCompetition(int id)
        {
            CompetitionDTO competition = repository.GetCompetition(id)?.ToDTO();
            if (competition == null) return NotFound($"Not competition found with id {id}");
            return competition;
        }
    }
}
