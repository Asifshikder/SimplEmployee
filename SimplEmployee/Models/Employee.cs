using Microsoft.AspNetCore.Authorization;

namespace SimplEmployee.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string NationalIdNo { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int DesignationId { get; set; }
        public Designation Designation { get; set; }
        public int AgreementTypeId { get; set; }
        public AgreementType AgreementType { get; set; }
        public string EmployeeImage { get; set; }
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        public int ReligionId { get; set; }
        public Religion Religion { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public ICollection<EmployeeContactInformation> EmployeeContactInformations { get; set; }
    }
}
