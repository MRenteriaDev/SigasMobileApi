using System;
using System.Collections.Generic;

namespace API.Models;

public partial class AggregatedCounter
{
    public int Id { get; set; }

    public string Key { get; set; } = null!;

    public long Value { get; set; }

    public DateTime? ExpireAt { get; set; }
}
