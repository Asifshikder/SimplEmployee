namespace SimplEmployee.Models
{
    public class AgreementType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
