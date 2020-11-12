using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Seed
{
    public class SerialNumberSeed : IEntityTypeConfiguration<SerialNumber>
    {
        public void Configure(EntityTypeBuilder<SerialNumber> builder)
        {
            var random = new Random();
            var serialNumberList = new List<SerialNumber>();
            for (int i = 0; i < 100; i++)
            {
                var number = random.Next(100000, 999999);
                serialNumberList.Add(new SerialNumber
                {
                    Id = Guid.NewGuid().ToString(),
                    SerialKey = number,
                    TimesUsed = 0
                });
            }
            builder.HasData(serialNumberList);
        }
    }
}
