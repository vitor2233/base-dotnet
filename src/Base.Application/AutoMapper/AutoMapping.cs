
using AutoMapper;
using Base.Communication.Requests;
using Base.Communication.Responses;
using Base.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Application.AutoMapper;
public class AutoMapping : Profile
{
    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }

    private void RequestToEntity()
    {
        CreateMap<RequestRegisterBaseJson, BaseEntity>();
    }

    private void EntityToResponse()
    {
        CreateMap<BaseEntity, ResponseRegisterBaseJson>();
    }
}