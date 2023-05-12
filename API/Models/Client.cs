using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Client
{
    public string Id { get; set; } = null!;

    public string Secret { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int ApplicationType { get; set; }

    public bool Active { get; set; }

    public int RefreshTokenLifeTime { get; set; }

    public string? AllowedOrigin { get; set; }
}
