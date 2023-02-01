namespace CapitalPlacementAPI.Models.ApplicationForm
{
    public class ProfileInformation
    {
        public int Id { get; set; }
        public GenericAttribute? Education { get; set; }
        public GenericAttribute? Experience { get; set; }
        public GenericAttribute? Resume { get; set; }
    }
}
