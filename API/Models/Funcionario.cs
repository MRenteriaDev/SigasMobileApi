using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Funcionario
{
    public int Id { get; set; }

    public int EnteId { get; set; }

    public string? Prefijo { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? Puesto { get; set; }

    public string? UnidadAdministrativa { get; set; }

    public string? Identificacion { get; set; }

    public string? TipoIdentificacion { get; set; }

    public string? Expedida { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public bool Activo { get; set; }

    public bool Titular { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

    public int TipoFuncionarioId { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Direccion { get; set; }

    public string? Nombramiento { get; set; }

    public DateTime? FechaNombramiento { get; set; }

    public string? IdentificacionEscaneada { get; set; }

    public virtual ICollection<AuditoriasFuncionario> AuditoriasFuncionarios { get; set; } = new List<AuditoriasFuncionario>();

    public virtual ICollection<CopiasOficio> CopiasOficios { get; set; } = new List<CopiasOficio>();

    public virtual Ente Ente { get; set; } = null!;

    public virtual ICollection<Oficio> Oficios { get; set; } = new List<Oficio>();

    public virtual ICollection<RecepcionDocumentacion> RecepcionDocumentacions { get; set; } = new List<RecepcionDocumentacion>();

    public virtual ICollection<Sancion> Sancions { get; set; } = new List<Sancion>();

    public virtual ICollection<Telefono> Telefonos { get; set; } = new List<Telefono>();

    public virtual TipoFuncionario TipoFuncionario { get; set; } = null!;
}
