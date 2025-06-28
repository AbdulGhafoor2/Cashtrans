namespace Cashtrans.DTOS
{
    public class ReadLockDataRequest
    {
        public string SerialNumber { get; set; }
    }
    public class ReadLockDataResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string LockData { get; set; } // Adjust based on the actual response structure
    }
}
