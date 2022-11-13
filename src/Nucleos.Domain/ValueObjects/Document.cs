using Nucleos.Domain.Enums;

namespace Nucleos.Domain.ValueObjects;

public struct Document
{
    public Document(string documentNumber, EDocumentType documentType)
    {
        DocumentNumber = documentNumber;
        DocumentType = documentType;
    }
    public string DocumentNumber { get; init; }
    public EDocumentType DocumentType { get; init; }
}