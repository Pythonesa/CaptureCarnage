using CaptureCarnageAPI.Contracts;
using CaptureCarnageAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CaptureCarnageAPI.Repositories
{
    public class OnMemoryCompetitions: ICompetitions
    {
        private readonly List<Competition> competitions = new()
        {
            new Competition
            {
                Id = 1,
                Name = "CyberCarnage 2024",
                Description = "The ultimate CTF showdown",
                StartDate = new DateTime(2024, 10, 1),
                EndDate = new DateTime(2024, 10, 3),
                Prizes = "1st Place: $5000, 2nd Place: $2500",
                IsActive = true
            },
            new Competition
            {
                Id = 2,
                Name = "HackFest Blitz",
                Description = "Quick fire CTF challenges for teams of 4",
                StartDate = new DateTime(2024, 11, 10),
                EndDate = new DateTime(2024, 11, 12),
                Prizes = "1st Place: $3000, Runner-up: $1000",
                IsActive = true
            },
            new Competition
            {
                Id = 3,
                Name = "CryptoCarnage",
                Description = "CTF with a focus on cryptography puzzles",
                StartDate = new DateTime(2024, 12, 5),
                EndDate = new DateTime(2024, 12, 7),
                Prizes = "Crypto rewards for top 3 teams",
                IsActive = true
            },
            new Competition
            {
                Id = 4,
                Name = "CTF Challenge: Warzone",
                Description = "Military-themed CTF competition",
                StartDate = new DateTime(2025, 1, 20),
                EndDate = new DateTime(2025, 1, 22),
                Prizes = "1st Place: $4000, 2nd Place: $2000",
                IsActive = true
            },
            new Competition
            {
                Id = 5,
                Name = "Capture the Ether",
                Description = "Blockchain-based CTF event",
                StartDate = new DateTime(2025, 3, 10),
                EndDate = new DateTime(2025, 3, 13),
                Prizes = "1st Place: 5 ETH, 2nd Place: 2 ETH",
                IsActive = false
            },
            new Competition
            {
                Id = 6,
                Name = "RootHack",
                Description = "Focus on privilege escalation challenges",
                StartDate = new DateTime(2025, 4, 1),
                EndDate = new DateTime(2025, 4, 3),
                Prizes = "Top 3 teams get prizes",
                IsActive = true
            },
            new Competition
            {
                Id = 7,
                Name = "StealthOps CTF",
                Description = "Spy-themed CTF with stealth missions",
                StartDate = new DateTime(2025, 5, 12),
                EndDate = new DateTime(2025, 5, 15),
                Prizes = "Winner: $2500, Runner-up: $1000",
                IsActive = true
            },
            new Competition
            {
                Id = 8,
                Name = "BinaryBrutality",
                Description = "Binary exploitation and reverse engineering",
                StartDate = new DateTime(2025, 6, 8),
                EndDate = new DateTime(2025, 6, 10),
                Prizes = "Cash prizes for top 5 participants",
                IsActive = true
            },
            new Competition
            {
                Id = 9,
                Name = "PwnTheSystem",
                Description = "All-out pwnage CTF",
                StartDate = new DateTime(2025, 7, 18),
                EndDate = new DateTime(2025, 7, 20),
                Prizes = "Winner: $7000",
                IsActive = true
            },
            new Competition
            {
                Id = 10,
                Name = "Hacktober Carnage",
                Description = "Annual Halloween CTF event with spooky challenges",
                StartDate = new DateTime(2025, 10, 28),
                EndDate = new DateTime(2025, 10, 31),
                Prizes = "1st Place: $3500, 2nd Place: $1500",
                IsActive = true
            }
        };

        public IEnumerable<Competition> GetCompetitions() => competitions.Where(c => c.IsActive);
        public Competition GetCompetition(int id) => competitions.Find(c => c.Id == id && c.IsActive);
    }
}
