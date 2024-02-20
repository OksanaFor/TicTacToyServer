using BLL.Interfases.Base;
using DTO.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TicTacToyServer.Controllers.Base
{
  
        [ApiController]
        [Route("[controller]")]
        public class BaseController<TDto, TModel, TKey> : ControllerBase
        {
            private readonly IBaseService<TDto, TKey> _service;
            public BaseController(IBaseService<TDto, TKey> service)
            {
                _service = service;
            }

            [Authorize]
            [HttpPost]
            [Route("[action]")]
            public virtual async Task Create(TDto dto)
            {
                await _service.Create(dto);
            }

            [Authorize]
            [HttpPost]
            [Route("[action]")]
            public List<TDto> GetAll(string[]? filter = null)
            {
                return _service.GetAll(filter);
            }

            [Authorize]
            [HttpPost]
            [Route("[action]")]
            public virtual async Task<TDto> GetById(GetByIdRequestDto<TKey> request)
            {
                return await _service.GetById(request);
            }

            [Authorize]
            [HttpPut]
            [Route("[action]")]
            public async virtual Task Update(TDto dtoToUpdate)
            {
                await _service.Update(dtoToUpdate);
            }

            [Authorize]
            [HttpDelete]
            [Route("[action]")]
            public async Task DeleteAsync(TKey id)
            {
                await _service.DeleteAsync(id);
            }
        }
    }

