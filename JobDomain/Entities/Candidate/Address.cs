namespace JobDomain.Entities.Candidate
{
    public class Address : Base
    {
        public string City { get; set; }
        public string State { get; set; }
        public int CandidateId { get; set; }
    }
}
