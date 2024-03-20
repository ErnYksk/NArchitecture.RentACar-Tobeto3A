using Application.Features.Brands.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Queries.GetListDynamic;

public class GetListBrandDynamicQueryHandler : IRequestHandler<GetListBrandDynamicQuery, CarListModel>
{
    private readonly IBrandRepository _brandRepository;
    private readonly IMapper _mapper;

    public GetListBrandDynamicQueryHandler(IBrandRepository brandRepository, IMapper mapper)
    {
        _brandRepository = brandRepository;
        _mapper = mapper;
    }

    public async Task<CarListModel> Handle(GetListBrandDynamicQuery request, CancellationToken cancellationToken)
    {
        IPaginate<Brand> brands = await _brandRepository.GetListByDynamicAsync(request.Dynamic, index: request.PageRequest.Page,
            size: request.PageRequest.PageSize);
        CarListModel brandListModel = _mapper.Map<CarListModel>(brands);
        return brandListModel;
    }
}