using CapitalPlacementAPI.Models.ApplicationForm;

namespace CapitalPlacementAPI.Service
{
    public interface IApplicationFormService
    {
        Task<ApplicationForm> GetApplicationFormData(int Id);
        Task SaveApplicationForm(ApplicationForm applicationForm);
        Task DeleteApplicationForm(int Id);
    }
}
