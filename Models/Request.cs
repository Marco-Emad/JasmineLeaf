namespace JasmineLeaf.Models
{
    public class Request
    {
        public int Id { get; set; }  // Primary Key

        public string UserId { get; set; }

        public string Status { get; set; } // Pending, Approved, Rejected

        public DateTime RequestedAt { get; set; }

        public DateTime? ReviewedAt { get; set; }
    }
}
