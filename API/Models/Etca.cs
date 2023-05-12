using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Etca
{
    public int Id { get; set; }

    public string? Formato { get; set; }

    public string? Ley { get; set; }

    public string? Tipo { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public string? Abreviatura { get; set; }

    public virtual ICollection<CumplimientoEtca> CumplimientoEtcas { get; set; } = new List<CumplimientoEtca>();

    public virtual ICollection<EtcasTipoEnte> EtcasTipoEntes { get; set; } = new List<EtcasTipoEnte>();
}
