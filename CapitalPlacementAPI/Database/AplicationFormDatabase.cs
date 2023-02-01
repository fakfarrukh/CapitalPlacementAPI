using CapitalPlacementAPI.Models.ApplicationForm;

namespace CapitalPlacementAPI.Database
{
    public class ApplicationFormDatabase : IApplicationFormDatabase
    {
        private readonly dynamic _database; // use proper database connection, I have just added placeholder
        public ApplicationFormDatabase() 
        {

        }

        public async Task<ApplicationForm> GetApplicationFormData(int Id)
        {
            // Here call database using db connection or any other service to get data
            ApplicationForm applicationForm = new ApplicationForm();
            return applicationForm;
        }
        public async Task SaveApplicationForm(ApplicationForm applicationForm)
        {
            // Here call database using db connection or any other service to save data
        }
        public async Task DeleteApplicationForm(int Id)
        {
            // Here call database using db connection or any other service to delete data\
        }
    }
}
