﻿using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Counter
{
    public int Id { get; set; }

    public string Key { get; set; } = null!;

    public short Value { get; set; }

    public DateTime? ExpireAt { get; set; }
}
