

using DTO.Request;

namespace BLL.Interfases.Base
{
    public interface IBaseService<TDto, TKey>
    {
        Task Create(TDto pass);
        List<TDto> GetAll(string[]? filter = null);
        Task<TDto> GetById(GetByIdRequestDto<TKey> request);
        Task Update(TDto dtoToUpdate);
        Task DeleteAsync(TKey id);
    }
}
