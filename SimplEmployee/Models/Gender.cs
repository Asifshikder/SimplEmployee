﻿namespace SimplEmployee.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
