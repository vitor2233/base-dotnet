
using Base.Communication.Requests;
using Base.Communication.Responses;

namespace Base.Application.UseCases.Register;

public interface IRegisterBaseUseCase
{
    Task<ResponseRegisterBaseJson> Execute(RequestRegisterBaseJson request);
}
