using System.Collections.Generic;

namespace OlympicGames.Models
{
    public static class CountryData
    {
        public static List<Country> Countries = new List<Country>
        {
            new Country { Id = 1, Name = "Canada", FlagUrl = "/images/canada.svg", Game = "Winter Olympics", Sport = "Curling", Type = "Indoor" },
            new Country { Id = 2, Name = "Sweden", FlagUrl = "/images/sweden.svg", Game = "Winter Olympics", Sport = "Curling", Type = "Indoor" },
            new Country { Id = 3, Name = "Great Britain", FlagUrl = "/images/GreatBritian.png", Game = "Winter Olympics", Sport = "Curling", Type = "Indoor" },
            new Country { Id = 4, Name = "Jamaica", FlagUrl = "/images/jamaica.svg", Game = "Winter Olympics", Sport = "Bobsleigh", Type = "Outdoor" },
            new Country { Id = 5, Name = "Italy", FlagUrl = "/images/italy.svg", Game = "Winter Olympics", Sport = "Bobsleigh", Type = "Outdoor" },
            new Country { Id = 6, Name = "Japan", FlagUrl = "/images/japan.svg", Game = "Winter Olympics", Sport = "Bobsleigh", Type = "Outdoor" },
            new Country { Id = 7, Name = "Germany", FlagUrl = "/images/germany.svg", Game = "Summer Olympics", Sport = "Diving", Type = "Indoor" },
            new Country { Id = 8, Name = "China", FlagUrl = "/images/china.svg", Game = "Summer Olympics", Sport = "Diving", Type = "Indoor" },
            new Country { Id = 9, Name = "Mexico", FlagUrl = "/images/mexico.svg", Game = "Summer Olympics", Sport = "Diving", Type = "Indoor" },
            new Country { Id = 10, Name = "Brazil", FlagUrl = "/images/brazil.svg", Game = "Summer Olympics", Sport = "Road Cycling", Type = "Outdoor" },
            new Country { Id = 11, Name = "Netherlands", FlagUrl = "/images/netherlands.svg", Game = "Summer Olympics", Sport = "Cycling", Type = "Outdoor" },
            new Country { Id = 12, Name = "USA", FlagUrl = "/images/us.svg", Game = "Summer Olympics", Sport = "Road Cycling", Type = "Outdoor" },
            new Country { Id = 13, Name = "Thailand", FlagUrl = "/images/thai.svg", Game = "Paralympics", Sport = "Archery", Type = "Indoor" },
            new Country { Id = 14, Name = "Uruguay", FlagUrl = "/images/uruguay.svg", Game = "Paralympics", Sport = "Archery", Type = "Indoor" },
            new Country { Id = 15, Name = "Ukraine", FlagUrl = "/images/ukraine.svg", Game = "Paralympics", Sport = "Archery", Type = "Indoor" },
            new Country { Id = 16, Name = "Austria", FlagUrl = "/images/austria.svg", Game = "Paralympics", Sport = "Canoe Sprint", Type = "Outdoor" },
            new Country { Id = 17, Name = "Pakistan", FlagUrl = "/images/pakistan.svg", Game = "Paralympics", Sport = "Canoe Sprint", Type = "Outdoor" },
            new Country { Id = 18, Name = "Zimbabwe", FlagUrl = "/images/zim.svg", Game = "Paralympics", Sport = "Canoe Sprint", Type = "Outdoor" },
            new Country { Id = 19, Name = "France", FlagUrl = "/images/france.svg", Game = "Youth Olympic Games", Sport = "Breakdancing", Type = "Indoor" },
            new Country { Id = 20, Name = "Cyprus", FlagUrl = "/images/cyprus.svg", Game = "Youth Olympic Games", Sport = "Breakdancing", Type = "Indoor" },
            new Country { Id = 21, Name = "Russia", FlagUrl = "/images/russia.svg", Game = "Youth Olympic Games", Sport = "Breakdancing", Type = "Indoor" },
            new Country { Id = 22, Name = "Finland", FlagUrl = "/images/finland.svg", Game = "Youth Olympic Games", Sport = "Skateboarding", Type = "Outdoor" },
            new Country { Id = 23, Name = "Slovakia", FlagUrl = "/images/slovakia.svg", Game = "Youth Olympic Games", Sport = "Skateboarding", Type = "Outdoor" },
            new Country { Id = 24, Name = "Portugal", FlagUrl = "/images/portugal.svg", Game = "Youth Olympic Games", Sport = "Skateboarding", Type = "Outdoor" }
       };
    }
}
