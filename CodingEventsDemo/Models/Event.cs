using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace CodingEventsDemo.Models
{
	public class Event
	{

		public string Name { get; set; }
		public string Description { get; set; }
		public string ContactEmail { get; set; }


		public int Id { get; }
		private static int nextId = 1;

		public Event(string name, string description, string contactEmail) : this()
		{
			Name = name;
			Description = description;
			ContactEmail = contactEmail;
		
		}

		public Event() 
		{
			
			Id = nextId;
			nextId++;
		}




		public override string ToString()
		{
			return Name;
		}

	}



}
