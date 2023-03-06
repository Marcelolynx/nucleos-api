using Nucleos.Domain.Enums;
using Nucleos.Domain.Validators;
using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Employe : Profile
{  
    public string Email { get; private set; } // Mover atriuibuto para classe Profile.
    
    public Employe(string email)
    {  
        Email = email; 
        _errors = new List<string>();
    }
    
    public override bool Validate()
    {
        var validator =  new EmployeValidator();
        var validation = validator.Validate(this);

        if (!validation.IsValid)
        {
            foreach (var error in validation.Errors)
                _errors.Add(error.ErrorMessage);

            throw new Exception("Erro ao validar o objeto" + _errors[0]);
        }

        return true;
    }
    

    protected Employe(){}
}