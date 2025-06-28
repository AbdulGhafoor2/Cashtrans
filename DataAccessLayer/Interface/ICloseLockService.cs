using Cashtrans.DTOS;

namespace Cashtrans.DataAccessLayer.Interface
{
    public interface ICloseLockService
    {
        Task<CloseLockResponse> CloseLockBySerialAsync(CloseLockRequest requestDto);
    }
}
