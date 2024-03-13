using Application.Features.Models.Dtos;
using MediatR;

namespace Application.Features.Models.Commands.Update;

public class UpdateModelCommand : IRequest<UpdatedModelResponse>
{
    public Guid Id { get; set; }
    public int BrandId { get; set; }
    public string Name { get; set; }
}