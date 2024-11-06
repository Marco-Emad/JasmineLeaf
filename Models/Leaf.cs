namespace JasmineLeaf.Models
{
	public class Leaf
	{
		public int Id { get; set; }  // Primary Key

		public string Name { get; set; }

		public byte[] Image { get; set; }  // Binary data for the image

		public string Stage { get; set; }

		public string Description { get; set; }
	}

}
