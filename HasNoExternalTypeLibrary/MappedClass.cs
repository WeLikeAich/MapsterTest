using Mapster;
using System;

namespace HasNoExternalTypeLibrary
{
    [AdaptTo("[name]Dto"), GenerateMapper]
    public class MappedClass
    {
    }
}