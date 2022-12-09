namespace loanSystem;

public class Loan
{
    public DateOnly _lendingDate;
    public DateOnly _dueDate;
    private User _lender;

    public Loan(DateOnly lendingDate, DateOnly dueDate, User lender)
    {
        _lendingDate = lendingDate;
        _dueDate = dueDate;
        _lender = lender;
    }
            
}