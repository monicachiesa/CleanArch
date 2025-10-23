using CleanArch.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Description", 9.99m, 99, "test");

            action.Should()
                  .NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Product(-1, "Product Name", "Description", 9.99m, 99, "test");
            action.Should()
                  .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                  .WithMessage("Invalid id value");
        }
    }
}
