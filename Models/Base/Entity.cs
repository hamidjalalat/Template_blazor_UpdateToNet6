﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Base
{
	public abstract class Entity 
	{
		public Entity() : base()
		{
			Id = Guid.NewGuid();
			InsertDateTime = Utility.Now;
		}
		
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Display(ResourceType = typeof(Resources.DataDictionary),Name = nameof(Resources.DataDictionary.Id))]
		public Guid Id { get; set; }


		[Display(ResourceType = typeof(Resources.DataDictionary),Name = nameof(Resources.DataDictionary.InsertDateTime))]
		public System.DateTime InsertDateTime { get; set; }
		
	}
}
