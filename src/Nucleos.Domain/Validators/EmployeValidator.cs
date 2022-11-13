using FluentValidation;
using Nucleos.Domain.Entities;

namespace Nucleos.Domain.Validators;

public class EmployeValidator : AbstractValidator<Employe>
{
    public EmployeValidator()
    {
        RuleFor(x => x.SocialName.CompanyName)
            .NotEmpty()
            .WithMessage("O nome do funcionário é obrigatório")
            
            .Length(2, 150)
            .WithMessage("O nome do funcionário deve ter entre 2 e 150 caracteres");
        
        RuleFor(x => x.SocialName.TradingName)
            .NotEmpty()
            .WithMessage("O nome fantasia do funcionário é obrigatório")
            
            .Length(2, 150)
            .WithMessage("O nome fantasia do funcionário deve ter entre 2 e 150 caracteres");
    }
}