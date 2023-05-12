﻿using System;
using System.Collections.Generic;

namespace API.Models;

public partial class ClasificacionNoConformidad
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual ICollection<NoConformidad> NoConformidads { get; set; } = new List<NoConformidad>();
}
