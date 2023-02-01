using CapitalPlacementAPI.Models.ApplicationForm;

namespace CapitalPlacementAPI.Database
{
    public interface IApplicationFormDatabase
    {
        Task<ApplicationForm> GetApplicationFormData(int Id);
        Task SaveApplicationForm(ApplicationForm applicationForm);
        Task DeleteApplicationForm(int Id);
    }
}
