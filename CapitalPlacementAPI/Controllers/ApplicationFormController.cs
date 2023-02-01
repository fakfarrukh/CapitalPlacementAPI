using CapitalPlacementAPI.Models.ApplicationForm;
using CapitalPlacementAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationFormController : ControllerBase
    {
        private readonly ILogger<ApplicationFormController> _logger;
        private readonly IApplicationFormService _applicationFormService;
        public ApplicationFormController(IApplicationFormService applicationFormService)
        {            
            _applicationFormService = applicationFormService;
        }

        // It will be used to load application form data based on Id
        [HttpGet]
        public async Task<ApplicationForm> Get(int Id)
        {
            // user internal service to load data
            return await _applicationFormService.GetApplicationFormData(Id);
        }

        // It will be used to save/update application form data based
        [HttpPost]
        public async Task<IActionResult> Post(ApplicationForm applicationForm)
        {
            // Call interal service class to save/update records
            await _applicationFormService.SaveApplicationForm(applicationForm);
            return Ok();
        }

        // It will be used to delete application form data based by on Id
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            // Call service to delete data
            await _applicationFormService.DeleteApplicationForm(Id);
            return Ok();
        }
    }
}
