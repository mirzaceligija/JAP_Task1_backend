﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs
{
    public class GetScreenplayDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Category { get; set; }
        public ICollection<GetActorsDto> Actors { get; set; }
        public double AverageRate { get; set; } = 0;
        public string PhotoUrl { get; set; }
    }
}
