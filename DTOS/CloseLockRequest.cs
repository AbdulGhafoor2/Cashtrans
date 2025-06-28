using System.Text.Json.Serialization;

namespace Cashtrans.DTOS
{
    public class CloseLockRequest
    {
        [JsonPropertyName("closeSealField")]
        public string CloseSeal { get; set; }

        [JsonPropertyName("dispatcherIDField")]
        public string? DispatcherID { get; set; }

        [JsonPropertyName("ifForcedClosedField")]
        public bool IfForcedClosed { get; set; }

        [JsonPropertyName("ifForcedClosedFieldSpecified")]
        public bool IfForcedClosedSpecified { get; set; } = true;

        [JsonPropertyName("itemElementNameField")]
        public int ItemElementName { get; set; } = 1; // 1 means SerialNumber

        [JsonPropertyName("itemField")]
        public string SerialNumber { get; set; }

        [JsonPropertyName("lockModeField")]
        public int LockMode { get; set; } // 0: F, 1: R

        [JsonPropertyName("lockSequenceField")]
        public string LockSequence { get; set; } = "0";
    }
    public class CloseLockResponse
    {
        public bool ifCloseSealDuressField { get; set; }
        public bool ifCloseSealDuressFieldSpecified { get; set; }
        public bool ifCloseSealLowBatteryField { get; set; }
        public bool ifCloseSealLowBatteryFieldSpecified { get; set; }

        public LockRecord lockRecordField { get; set; }
        public ResultRecord resultRecordField { get; set; }
        public TransactionCloseLock tRANSACTION_CLOSE_LOCKField { get; set; }
    }
    public class TransactionCloseLock
    {
        public string closeSealField { get; set; }
        public string dispatcherIDField { get; set; }
        public bool ifForcedClosedField { get; set; }
        public bool ifForcedClosedFieldSpecified { get; set; }
        public int itemElementNameField { get; set; } = 1; // 1 = SerialNumber
        public string itemField { get; set; }              // SerialNumber
        public int lockModeField { get; set; }
        public string lockSequenceField { get; set; } = "0";
    }
   
}
