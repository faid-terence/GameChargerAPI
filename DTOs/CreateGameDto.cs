using System;

namespace GameManagement.DTOs
{
    public record class CreateGameDto(

        string Name,
        string Description,
        string Genre,
        decimal Price,
        DateOnly ReleaseDate
    );
}