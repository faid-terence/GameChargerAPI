using System;

namespace GameManagement.DTOs
{
    public record class UpdateGameDto(
        string Name,
        string Description,
        string Genre,
        decimal Price,
        DateOnly ReleaseDate
    );
}