namespace CapitalPlacementAPI.Models.ApplicationForm
{
    public class ApplicationForm
    {
        public int Id { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public ProfileInformation  ProfileInformation { get; set; }
        public List<Questions> Questions { get; set; }
    }
}
