using Application.Features.Brands.Dtos;
using Core.Persistence.Paging;

namespace Application.Features.Brands.Models;

public class CarListModel : BasePageableModel
{
    public IList<GetAllBrandsResponse> ListBrands { get; set; }
}