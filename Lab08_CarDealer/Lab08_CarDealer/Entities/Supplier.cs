﻿using System;
using System.Collections.Generic;

namespace Lab08_CarDealer.Entities;

public partial class Supplier
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool IsImporter { get; set; }

    public virtual ICollection<Part> Parts { get; set; } = new List<Part>();
}
