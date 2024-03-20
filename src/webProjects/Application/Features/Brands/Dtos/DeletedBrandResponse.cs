namespace Application.Features.Brands.Dtos;

public class DeletedBrandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime DeletedDate { get; set; }
}