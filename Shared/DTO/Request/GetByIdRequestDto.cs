

namespace DTO.Request
{
    public class GetByIdRequestDto<TKey>
    {
        public TKey Id { get; set; }
        public string[]? Filter { get; set; } = null;
    }
}
