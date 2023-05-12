using System;
using System.Collections.Generic;

namespace API.Models;

public partial class StatusArea
{
    public int Id { get; set; }

    public int StatusId { get; set; }

    public int AreaId { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
