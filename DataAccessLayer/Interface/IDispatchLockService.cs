using Cashtrans.DTOS;

namespace Cashtrans.DataAccessLayer.Interface
{
    public interface IDispatchLockService
    {
        Task<DispatchLockResponse> DispatchLockAsync(DispatchLockRequest request);
    }
}
