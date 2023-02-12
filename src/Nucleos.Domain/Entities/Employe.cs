using Nucleos.Domain.Enums;
using Nucleos.Domain.Validators;
using Nucleos.Domain.ValueObjects;

namespace Nucleos.Domain.Entities;

public class Employe : Profile
{
    public EGender Gender { get; private set; }
    public string JobRole { get; private set; }
    public string Function { get; private set; }
    public string Email { get; private set; } // Mover atriuibuto para classe Profile.
    public string MotherName { get; private set; }
    public int Cpf { get; private set; } // ValueObject?
    public int Rg { get; private set; }
    public DateTime BirthDateTime { get; private set; }
    public DateTime StartDateTime { get; private set; }
    public DateTime? EndDateTime { get; private set; }
    public double Salary { get; set; }
    
    public Employe(EGender gender, string jobRole, string function, 
        string motherName, int cpf, int rg, DateTime birthDateTime, DateTime startDateTime, 
        DateTime? endDateTime, double salary, string email)
    {
        Gender = gender;
        JobRole = jobRole;
        Function = function;
        MotherName = motherName;
        Email = email;
        Cpf = cpf;
        Rg = rg;
        BirthDateTime = birthDateTime;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
        Salary = salary;
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