using Angular_Essential_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Angular_Essential_API.Repositories.Seed
{
    public class CostSeed : IEntityTypeConfiguration<Cost>
    {
        public void Configure(EntityTypeBuilder<Cost> builder)
        {
            builder.HasData(
                new Cost
                {
                    Id = new Guid("2f0e1e03-9438-4d46-9809-5f530ca12348"),
                    Amount = 145254.25M,
                    MovieID = new Guid("06f158fe-277f-469b-adb3-878e3ec53e63")
                },
                new Cost
                {
                    Id = new Guid("2f0e1e03-9438-4d46-9809-5f530ca12347"),
                    Amount = 154785441.22M,
                    MovieID = new Guid("06f158fe-277f-469b-adb3-878e3ec53e63")
                },
                new Cost
                {
                    Id = new Guid("2f0e1e03-9438-4d46-9809-5f530ca12346"),
                    Amount = 1500.00M,
                    MovieID = new Guid("c8a235b0-0764-49c5-b930-74ec0951c388")
                
                },
                new Cost
                {
                    Id = new Guid("2f0e1e03-9438-4d46-9809-5f530ca12345"),
                    Amount = 13254784.00M,
                    MovieID = new Guid("c40dea06-64c2-4e32-b1be-66de42062ec2")
                }
                );
        }
    }
}
