using System;
using System.Collections.Generic;

namespace Lab08_CarDealer.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public bool IsYoungDriver { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
