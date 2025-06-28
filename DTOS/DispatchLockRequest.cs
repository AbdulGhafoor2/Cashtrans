
namespace Cashtrans.DTOS
{
   
    public class DispatchLockRequest
    {
        public string dispatcherIDField { get; set; } = null;
        public bool ifSecondLineMaintenanceCallField { get; set; } = false;
        public bool ifSecondLineMaintenanceCallFieldSpecified { get; set; } = false;
        public int itemElementNameField { get; set; } = 1; // 1 = SerialNumber
        public string itemField { get; set; }              // Lock Serial Number
        public int lockModeField { get; set; } = 2;            // 0 = FLM, 1 = Route
        public string user1IDField { get; set; }           // First User
        public string user2IDField { get; set; }  // Optional second user
    }
    public class DispatchLockResponse
    {
        public LockRecord lockRecordField { get; set; }
        public ResultRecord resultRecordField { get; set; }
        public DispatchTransaction TRANSACTION_DISPATCH_LOCKFIELD { get; set; }

    }

    public class LockRecord
    {
        public string aTMSerialNumberField { get; set; }
        public string address1Field { get; set; }
        public string address2Field { get; set; }
        public string auditCountField { get; set; }
        public string bankBranchNameField { get; set; }
        public object bankModeUserNameArrayField { get; set; }
        public string bankOpenDelayField { get; set; }
        public string bankOpenWindowField { get; set; }
        public string cityField { get; set; }
        public string closeSealLengthField { get; set; }
        public string closeTime1Field { get; set; }
        public string closeTime2Field { get; set; }
        public string closeTime3Field { get; set; }
        public string countryField { get; set; }
        public string customerIDField { get; set; }
        public string customerNumberField { get; set; }
        public string description1Field { get; set; }
        public string description2Field { get; set; }
        public string description3Field { get; set; }
        public string description4Field { get; set; }
        public string dispatcherID1Field { get; set; }
        public string dispatcherID2Field { get; set; }
        public string dispatcherID3Field { get; set; }
        public string displayIssuedComboUser1Seq1Field { get; set; }
        public string displayIssuedComboUser1Seq2Field { get; set; }
        public string displayIssuedComboUser1Seq3Field { get; set; }
        public string displayIssuedComboUser2Seq1Field { get; set; }
        public string displayIssuedComboUser2Seq2Field { get; set; }
        public string displayIssuedComboUser2Seq3Field { get; set; }
        public string duressDateField { get; set; }
        public string groupNameField { get; set; }
        public bool ifActivationCallField { get; set; }
        public bool ifDualModeField { get; set; }
        public bool ifForcedClosedField { get; set; }
        public bool ifLastRoute1IssuedField { get; set; }
        public bool ifLastRoute2IssuedField { get; set; }
        public bool ifLastRoute3IssuedField { get; set; }
        public bool ifLegacyImportField { get; set; }
        public bool ifLockOpenField { get; set; }
        public bool ifNoAlarmField { get; set; }
        public bool ifPreviousRoute1IssuedField { get; set; }
        public bool ifPreviousRoute2IssuedField { get; set; }
        public bool ifPreviousRoute3IssuedField { get; set; }
        public bool ifRoute1IssuedField { get; set; }
        public bool ifRoute2IssuedField { get; set; }
        public bool ifRoute3IssuedField { get; set; }
        public bool ifSecondLineMaintenanceCallField { get; set; }
        public bool ifUnassignedOpenCallField { get; set; }
        public string issuedComboUser1Seq1Field { get; set; }
        public string issuedComboUser1Seq2Field { get; set; }
        public string issuedComboUser1Seq3Field { get; set; }
        public string issuedComboUser2Seq1Field { get; set; }
        public string issuedComboUser2Seq2Field { get; set; }
        public string issuedComboUser2Seq3Field { get; set; }
        public string keyCloseSealField { get; set; }
        public string lastUsedDateField { get; set; }
        public string lockActivationStatusField { get; set; }
        public string lockDispatchStatusField { get; set; }
        public string lockHardwareModelField { get; set; }
        public int lockModeField { get; set; }
        public string lockNameField { get; set; }
        public string lowBatteryDateField { get; set; }
        public string networkAddressField { get; set; }
        public string networkPortField { get; set; }
        public string openTime1Field { get; set; }
        public string openTime2Field { get; set; }
        public string openTime3Field { get; set; }
        public string openTries1Field { get; set; }
        public string openTries2Field { get; set; }
        public string openTries3Field { get; set; }
        public string originalSerialNumberField { get; set; }
        public string previousCloseTime1Field { get; set; }
        public string previousCloseTime2Field { get; set; }
        public string previousCloseTime3Field { get; set; }
        public string previousComboUser1Seq1Field { get; set; }
        public string previousComboUser1Seq2Field { get; set; }
        public string previousComboUser1Seq3Field { get; set; }
        public string previousComboUser2Seq1Field { get; set; }
        public string previousComboUser2Seq2Field { get; set; }
        public string previousComboUser2Seq3Field { get; set; }
        public string previousOpenTime1Field { get; set; }
        public string previousOpenTime2Field { get; set; }
        public string previousOpenTime3Field { get; set; }
        public string previousRouteName1Field { get; set; }
        public string previousRouteName2Field { get; set; }
        public string previousRouteName3Field { get; set; }
        public string previousRouteSeal1Field { get; set; }
        public string previousRouteSeal2Field { get; set; }
        public string previousRouteSeal3Field { get; set; }
        public string previousSealField { get; set; }
        public string previousUser1ID1Field { get; set; }
        public string previousUser1ID2Field { get; set; }
        public string previousUser1ID3Field { get; set; }
        public string previousUser2ID1Field { get; set; }
        public string previousUser2ID2Field { get; set; }
        public string previousUser2ID3Field { get; set; }
        public int recordTypeField { get; set; }
        public string regionField { get; set; }
        public string routeName1Field { get; set; }
        public string routeName2Field { get; set; }
        public string routeName3Field { get; set; }
        public string routeSeal1Field { get; set; }
        public string routeSeal2Field { get; set; }
        public string routeSeal3Field { get; set; }
        public string sealField { get; set; }
        public string serialNumberField { get; set; }
        public string serviceBranchField { get; set; }
        public string startDateField { get; set; }
        public string stateField { get; set; }
        public string timeZoneIDField { get; set; }
        public string transferReturnCodeField { get; set; }
        public string user1ID1Field { get; set; }
        public string user1ID2Field { get; set; }
        public string user1ID3Field { get; set; }
        public string user2ID1Field { get; set; }
        public string user2ID2Field { get; set; }
        public string user2ID3Field { get; set; }
        public string userDefined1Field { get; set; }
        public string userDefined2Field { get; set; }
        public string userDefined3Field { get; set; }
        public string userDefined4Field { get; set; }
        public string zIPField { get; set; }
    
    // Add additional fields as required...
}

    public class ResultRecord
    {
        public List<string> descriptionField { get; set; }
        public string errorCodeField { get; set; }
        public bool ifRetryValidField { get; set; }
        public int resultField { get; set; }
    }
    public class DispatchTransaction
    {
        public string dispatcherIDField { get; set; }
        public bool ifSecondLineMaintenanceCallField { get; set; }
        public bool ifSecondLineMaintenanceCallFieldSpecified { get; set; }
        public int itemElementNameField { get; set; }
        public string itemField { get; set; }
        public int lockModeField { get; set; }
        public string user1IDField { get; set; }
        public string user2IDField { get; set; }
    }
}
