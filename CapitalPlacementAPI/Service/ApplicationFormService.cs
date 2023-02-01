using CapitalPlacementAPI.Models.ApplicationForm;

namespace CapitalPlacementAPI.Service
{
    public class ApplicationFormService : IApplicationFormService
    {
        private readonly IApplicationFormService _applicationFormService;
        public ApplicationFormService(IApplicationFormService applicationFormService)
        {
            _applicationFormService = applicationFormService;
        }
        public async Task<ApplicationForm> GetApplicationFormData(int Id)
        {
            // apply any business logic and call database

            return await _applicationFormService.GetApplicationFormData(Id);
        }
        public async Task SaveApplicationForm(ApplicationForm applicationForm)
        {
            // apply any business logic and call database
            await _applicationFormService.SaveApplicationForm(applicationForm);
        }
        public async Task DeleteApplicationForm(int Id)
        {
            // apply any business logic and call database
            await _applicationFormService.DeleteApplicationForm(Id);
        }

    }
}
