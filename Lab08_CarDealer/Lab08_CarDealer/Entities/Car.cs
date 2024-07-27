﻿using System;
using System.Collections.Generic;

namespace Lab08_CarDealer.Entities;

public partial class Car
{
    public int Id { get; set; }

    public string Make { get; set; } = null!;

    public string Model { get; set; } = null!;

    public long TravelledDistance { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

    public virtual ICollection<Part> Parts { get; set; } = new List<Part>();
}
