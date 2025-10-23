using CleanArch.Domain.Validation;
using System.Collections.Generic;

namespace CleanArch.Domain.Entities
{
    public sealed class Category : Entity// não pode ser herdada por causa do sealed
    {

        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid id value");
            Id = id;
            ValidateDomain(name);
        }
        public void Update(string name)
        {
            ValidateDomain(name);
        }
        public ICollection<Product> Products { get; private set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name! Name is required");

            DomainExceptionValidation.When(name.Length < 3, "Invalid name! Too short minimal 3 characters");

            Name = name;
        }
    }
}
