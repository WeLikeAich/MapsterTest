using Mapster;
using System;

namespace HasExternalTypeLibrary
{
    [AdaptTo("[name]Dto"), GenerateMapper]
    public class MappedClass
    {
        public Guid Id { get; set; }
    }
}