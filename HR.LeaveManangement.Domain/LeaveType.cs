using HR.LeaveManangement.Domain.Common;

namespace HR.LeaveManangement.Domain
{
    public class LeaveType : BaseDomainEntity
    {
       
        public string Name { get; set; }
        public int DefaultDays { get; set; }
      
    }
}