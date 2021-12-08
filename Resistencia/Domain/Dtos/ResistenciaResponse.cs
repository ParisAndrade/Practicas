using System;

namespace ResistorApp.Domain.Dtos
{
    public record ResistenciaResponse(double Value, string Unit, int Tolerance);
}