namespace CapitalPlacementAPI.Models.ApplicationForm
{
    public class PersonalInformation
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public GenericAttribute? Email { get; set; }
        public GenericAttribute? Phone { get; set; }
        public GenericAttribute? Nationality { get; set;}
        public GenericAttribute? CurrentlyBased { get; set;}
    }

    
}
