namespace SimplEmployee.Models
{
    public class EmployeeContactInformation
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee  { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
    }
}
