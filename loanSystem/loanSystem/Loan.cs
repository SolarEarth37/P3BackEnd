namespace loanSystem;

public class Loan
{
    private DateOnly _lendingDate;
    private DateOnly _dueDate;
    private User _lender;

    public Loan(DateOnly lendingDate, DateOnly dueDate, User lender)
    {
        _lendingDate = lendingDate;
        _dueDate = dueDate;
        _lender = lender;
    }
            
}