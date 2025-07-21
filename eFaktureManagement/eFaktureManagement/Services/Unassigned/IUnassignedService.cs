using eFaktureManagement.Dto.Unassigned;

namespace eFaktureManagement.Services.Unassigned
{
    public interface IUnassignedService
    {

        AssignResultDto Assign(AssignDto dto);
        void MarkAsScrap(int invoiceId);


    }
}
