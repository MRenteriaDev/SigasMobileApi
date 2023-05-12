using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Lista69Bdetalle
{
    public int Id { get; set; }

    public int No { get; set; }

    public int Lista69Bid { get; set; }

    public string? Rfc { get; set; }

    public string? NombreContribuyente { get; set; }

    public string? SituacionContribuyente { get; set; }

    public string? NooficioglobalPresuncionSat { get; set; }

    public string? NooficioglobalPresuncionDof { get; set; }

    public string? NooficioglobalDesvirtuaronSat { get; set; }

    public string? NooficioglobalDesvirtuaronDof { get; set; }

    public string? NooficioglobalDefinitivosSat { get; set; }

    public string? NooficioglobalDefinitivosDof { get; set; }

    public string? NooficioglobalSentenciaFavorableSat { get; set; }

    public string? NooficioglobalSentenciaFavorableDof { get; set; }

    public string? PpPresuntos { get; set; }

    public string? PDofPresuntos { get; set; }

    public string? PpDesvirtuados { get; set; }

    public string? PDofDesvirtuados { get; set; }

    public string? PpDefinitivos { get; set; }

    public string? PDofDefinitivos { get; set; }

    public string? PpSentenciaFavorable { get; set; }

    public string? PDofSentenciaFavorable { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public virtual Lista69B Lista69B { get; set; } = null!;
}
