namespace loanSystem;

public class LoanDevice:Loan
{
    private List<Device> _devices;

    public LoanDevice(DateOnly lendingDate, DateOnly dueDate, User lender, List<Device> devices) : base(lendingDate, dueDate, lender)
    {
        _devices = devices;
    }

    public List<Device> Devices => _devices;
}