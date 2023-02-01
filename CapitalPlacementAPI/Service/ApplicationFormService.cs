using CapitalPlacementAPI.Database;
using CapitalPlacementAPI.Models.ApplicationForm;

namespace CapitalPlacementAPI.Service
{
    public class ApplicationFormService : IApplicationFormService
    {
        private readonly IApplicationFormDatabase _applicationFormDatabase;
        public ApplicationFormService(IApplicationFormDatabase applicationFormDatabase)
        {
            _applicationFormDatabase = applicationFormDatabase;
        }
        public async Task<ApplicationForm> GetApplicationFormData(int Id)
        {
            // apply any business logic and call database

            return await _applicationFormDatabase.GetApplicationFormData(Id);
        }
        public async Task SaveApplicationForm(ApplicationForm applicationForm)
        {
            // apply any business logic and call database
            await _applicationFormDatabase.SaveApplicationForm(applicationForm);
        }
        public async Task DeleteApplicationForm(int Id)
        {
            // apply any business logic and call database
            await _applicationFormDatabase.DeleteApplicationForm(Id);
        }

    }
}
