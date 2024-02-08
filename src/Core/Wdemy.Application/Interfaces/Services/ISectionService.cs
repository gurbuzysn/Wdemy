using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Sections;
using Wdemy.Application.Dtos.Videos;
using Wdemy.Application.Utilities.Result;

namespace Wdemy.Application.Interfaces.Services
{
    public interface ISectionService
    {
        Task<IDataResult<SectionDto>> GetByIdAsync(Guid id);
        Task<string> GetSectionNameByIdAsync(Guid id);
        Task<IDataResult<List<SectionDto>>> GetAllAsync();
        Task<IResult> DeleteAsync(Guid id);
        Task<IDataResult<SectionDto>> UpdateAsync(SectionDto sectionDto);
    }
}
