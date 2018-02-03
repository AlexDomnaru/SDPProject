using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Domain.Entities
{
    public interface IEntity
    {
		[Key]
		[Required]
		Guid Id { get; set; }
    }
}
