using System;
using System.Collections.Generic;

namespace API.Models;

public partial class RefreshToken
{
    public string Id { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string ClientId { get; set; } = null!;

    public DateTime IssuedUtc { get; set; }

    public DateTime ExpiresUtc { get; set; }

    public string ProtectedTicket { get; set; } = null!;
}
