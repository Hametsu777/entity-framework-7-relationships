namespace EntityFramework7Relationships.DTOs
{
    // Use Dto to transfer data to the server and return data back to the client.
    public record struct CharacterCreateDto(
        string Name,
        BackpackCreateDto Backpack,
        List<WeaponCreateDto> Weapons,
        List<FactionCreateDto> Factions);
}
