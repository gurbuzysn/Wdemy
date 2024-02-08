using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Constant;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Dtos.Sections;
using Wdemy.Application.Interfaces.Repository;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Application.Utilities.Result;
using Wdemy.Application.Utilities.Result.Concrete;
using Wdemy.Domain.Entities;

namespace Wdemy.Application.Services
{
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly IMapper _mapper;

        public SectionService(ISectionRepository sectionRepository, IMapper mapper)
        {
            _sectionRepository = sectionRepository;
            _mapper = mapper;
        }

        public Task<IResult> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<SectionDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<SectionDto>> GetByIdAsync(Guid id)
        {
            var section = await  _sectionRepository.GetByIdAsync(id);

            if (section == null)
            {
                return new ErrorDataResult<SectionDto>(Messages.SectionNotFound);
            }

            return new SuccessDataResult<SectionDto>(_mapper.Map<SectionDto>(section), Messages.AddSuccess);
        }

        public async Task<string> GetSectionNameByIdAsync(Guid id)
        {
            var section = await _sectionRepository.GetByIdAsync(id);

            if (section == null)
            {
                return Messages.SectionNotFound;
            }

            return section.Name;
        }

        public Task<IDataResult<SectionDto>> UpdateAsync(SectionDto sectionDto)
        {
            throw new NotImplementedException();
        }
    }
}
