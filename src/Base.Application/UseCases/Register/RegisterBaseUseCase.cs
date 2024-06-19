using AutoMapper;
using Base.Communication.Requests;
using Base.Communication.Responses;
using Base.Domain.Entities;
using Base.Domain.Repositories;
using Base.Domain.Repositories.Base;
using Base.Exception.ExceptionBase;

namespace Base.Application.UseCases.Register;

public class RegisterBaseUseCase : IRegisterBaseUseCase
{
    private readonly IBaseRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterBaseUseCase(IBaseRepository repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ResponseRegisterBaseJson> Execute(RequestRegisterBaseJson request)
    {
        Validate(request);

        var entity = _mapper.Map<BaseEntity>(request);

        await _repository.Add(entity);

        await _unitOfWork.Commit();

        return _mapper.Map<ResponseRegisterBaseJson>(entity);
    }

    private void Validate(RequestRegisterBaseJson request)
    {
        var validator = new BaseValidator();

        var result = validator.Validate(request);
        if (!result.IsValid)
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errorMessages);
        }

    }
}
