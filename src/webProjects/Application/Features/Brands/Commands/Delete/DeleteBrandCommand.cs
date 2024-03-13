using Application.Features.Brands.Dtos;
using MediatR;

namespace Application.Features.Brands.Commands.Delete
{
    public class DeleteBrandCommand : IRequest<DeletedBrandResponse>
    {
        public Guid Id { get; set; }
    }
}
