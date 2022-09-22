namespace nzwalksAPI.Models.Domain
{
    public class WalkDifficulty
    {
        public Guid Id { get; set; }
        public string Code { get; set; }

        //navigation properties
        public IEnumerable<Walk> Walks { get; set; }

    }
}