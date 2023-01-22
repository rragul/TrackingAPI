using System.ComponentModel.DataAnnotations;

namespace TrackingAPI.Models
{
	public class Issue
	{
		public int Id { get; set; }
		[Required]
		public string? Title { get; set; }
		[Required]
		public string? Description { get; set; }

		public PriorityEnum Priority { get; set; }

		public IssuTypeEnum IssuType { get; set; }

		public DateTime Created { get; set; }
		
		public DateTime? Completed { get; set; }
		
		public enum PriorityEnum
		{
			Low, Medium, High
		}
		
		public enum IssuTypeEnum
		{
			Feature, Bug, Documentation
		}
		
	}
}
