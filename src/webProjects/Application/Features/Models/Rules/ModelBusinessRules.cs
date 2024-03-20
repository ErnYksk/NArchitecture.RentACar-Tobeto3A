using Application.Services.Repositories;
using Core.Application.Rules;
using Domain.Entities;

namespace Application.Features.Models.Rules;

public class ModelBusinessRules : BaseBusinessRules
{
    private readonly IModelRepository _modelRepository;

    public ModelBusinessRules(IModelRepository modelRepository)
    {
        _modelRepository = modelRepository;
    }

    public void ModelIdShouldExistWhenSelected(Model? model)
    {
        if (model == null)
            throw new Exception("Model with this Id does not exist!");
    }
}