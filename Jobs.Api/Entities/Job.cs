namespace Jobs.Api.Entities
{
    public class Job
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public decimal Salary { get; set; }
        public DateTime CreatedAt { get; set; }

        public Job()
        {
            Id = uint.MinValue;
            Title = string.Empty;
            Description = string.Empty;
            Company = string.Empty;
            Location = string.Empty;
            Salary = decimal.Zero;
            CreatedAt = DateTime.Now;
        }

        public void Update(Job job)
        {
            Id = job.Id;
            Title = job.Title;
            Description = job.Description;
            Company = job.Company;
            Location = job.Location;
            Salary = job.Salary;
        }
    }
}
