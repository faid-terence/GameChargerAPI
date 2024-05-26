using System;

namespace GameManagement.DTOs
{
    public record class GameDto(
        int Id,
        string Name,
        string Description,
        string Genre,
        decimal Price,
        DateOnly ReleaseDate
    );
}
