using SeparateProject.Models;
using Service.DTOS;

namespace Service.DTOS
{
    public static partial class MappedClassMapper
    {
        public static MappedClassDto AdaptToDto(this MappedClass p1)
        {
            return p1 == null ? null : new MappedClassDto() {Id = p1.Id};
        }
        public static MappedClassDto AdaptTo(this MappedClass p2, MappedClassDto p3)
        {
            if (p2 == null)
            {
                return null;
            }
            MappedClassDto result = p3 ?? new MappedClassDto();
            
            result.Id = p2.Id;
            return result;
            
        }
    }
}