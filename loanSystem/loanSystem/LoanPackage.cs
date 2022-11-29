namespace loanSystem;

public class LoanPackage: Loan
{
    private List<Package> _packages;
    
    public LoanPackage(DateOnly lendingDate, DateOnly dueDate, User lender, List<Package> packages) : base(lendingDate, dueDate, lender)
    {
        _packages = packages;
    }

    public List<Package> Packages => _packages;
}