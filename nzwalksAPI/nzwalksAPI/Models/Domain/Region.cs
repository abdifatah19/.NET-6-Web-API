namespace nzwalksAPI.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double lat { get; set; }
        public double Long { get; set; }
        public long population { get; set; }

        //navigation properties
        public IEnumerable<Walk> Walks { get; set; }
    }
}
