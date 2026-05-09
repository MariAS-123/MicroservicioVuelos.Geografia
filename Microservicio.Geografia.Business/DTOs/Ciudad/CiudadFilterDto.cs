namespace Microservicio.Geografia.Business.DTOs.Ciudad;

public class CiudadFilterDto
{
    public int? IdPais { get; set; }

    public string? Nombre { get; set; }

    public string? CodigoPostal { get; set; }

    public string? ZonaHoraria { get; set; }

    public string? Estado { get; set; }

    public int PaginaActual { get; set; } = 1;

    public int TamanoPagina { get; set; } = 20;
}