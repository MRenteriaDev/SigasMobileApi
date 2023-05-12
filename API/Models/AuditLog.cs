﻿using System;
using System.Collections.Generic;

namespace API.Models;

public partial class AuditLog
{
    public long AuditLogId { get; set; }

    public string? UserName { get; set; }

    public DateTime EventDateUtc { get; set; }

    public int EventType { get; set; }

    public string TypeFullName { get; set; } = null!;

    public string RecordId { get; set; } = null!;

    public virtual ICollection<AuditLogDetail> AuditLogDetails { get; set; } = new List<AuditLogDetail>();

    public virtual ICollection<LogMetadatum> LogMetadata { get; set; } = new List<LogMetadatum>();
}
