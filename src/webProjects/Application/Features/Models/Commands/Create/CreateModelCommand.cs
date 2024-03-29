﻿using Application.Features.Models.Dtos;
using MediatR;

namespace Application.Features.Models.Commands.Create;

public class CreateModelCommand : IRequest<CreatedModelResponse>
{
    public Guid BrandId { get; set; }
    public string Name { get; set; }
}
