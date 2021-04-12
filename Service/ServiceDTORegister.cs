using Mapster;
using System.Reflection;

namespace Service
{
    public class ServiceDTORegister : ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            var as1 = Assembly.Load("SeparateProject");
            config.AdaptTo("[name]Dto")
                    .ForAllTypesInNamespace(as1, "SeparateProject.Models");

            config.GenerateMapper("[name]Mapper")
                .ForAllTypesInNamespace(as1, "SeparateProject.Models");
        }
    }
}