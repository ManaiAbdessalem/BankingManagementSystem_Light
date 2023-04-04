using AutoMapper;
using BankingManagement_Domain.AccountAggreagate;
using BankingManagement_Domain.TransactionAggregate;

namespace BankingManagement_Service.AccountAggreagate;

/// <summary>
/// Class <see cref="AccountService"/> containing Account Services.
/// </summary>
public class AccountService : IAccountService
{
    private IMapper _mapper { get; set; }

    /// <summary>
    /// Constructor of AccountService.
    /// </summary>
    /// <param name="accountRepository">accountRepository</param>
    public AccountService(IMapper mapper)
    {
        _mapper = mapper;
    }

    /// <inheritdoc />
    public void UpdateAccount(string accountToUpdateRib, double ammount, OperationType operationType)
    {
    }

    /// <inheritdoc />
    public Account GetAccountByRib(string rib)
    {
        Account account = new Account()
        {
            Balance = 123,
            FirstNameBeneficiary = "Abdessalem",
            LastNameBeneficiary = "Manai",
            RIB = rib
        };
        return _mapper.Map<Account>(account);
    }

    /// <inheritdoc />
    public Account GetAccountHistory(string rib)
    {
        Account account = GetAccountByRib(rib);
        if (account == null)
        {
            return null;
        }
        account.Transactions = new List<Transaction>()
        {
            new Transaction(){ Ammount=25,OperationType=OperationType.credit} ,
            new Transaction(){ Ammount=10,OperationType=OperationType.debit}
        };

        return account;
    }
}