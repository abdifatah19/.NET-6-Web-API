﻿namespace nzwalksAPI.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid walkDifficulty { get; set; }
        public Guid RegionId { get; set; }

        //navigation properties
        public Region Region{ get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
