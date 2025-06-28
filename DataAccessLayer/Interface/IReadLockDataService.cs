using Cashtrans.DTOS;

namespace Cashtrans.DataAccessLayer.Interface
{
    public interface IReadLockDataService
    {
        Task<ReadLockDataResponse> ReadLockDataBySerialAsync(ReadLockDataRequest request);
    }
}
