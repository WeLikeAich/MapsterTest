using Mapster;
using SeparateProject.Models;
using Service.DTOS;
using System;

namespace Service
{
    public class TestService : ITestService
    {
        public MappedClassDto GetMappedObject()
        {
            MappedClass source = new MappedClass() { Id = Guid.NewGuid() };
            var destination = source.Adapt<MappedClassDto>();
            return destination;
        }
    }
}