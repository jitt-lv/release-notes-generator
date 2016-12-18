﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ReleaseNotesGenerator.Dal
{
    public interface IEntityMappingConfiguration<T> : IEntityMappingConfiguration where T : class
    {
        void Map(EntityTypeBuilder<T> builder);
    }

    public interface IEntityMappingConfiguration
    {
        void Map(ModelBuilder b);
    }
}
