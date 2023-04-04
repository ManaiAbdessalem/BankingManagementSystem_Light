using BankingManagement_Domain.AccountAggreagate;
using BankingManagement_Domain.TransactionAggregate;

namespace BankingManagement_Service.AccountAggreagate;

/// <summary>
/// Interface <see cref="IAccountService"/> containing Account services.
/// </summary>
public interface IAccountService
{
    /// <summary>
    /// Updates an Account.
    /// </summary>
    /// <param name="accountToUpdateRib">accountToUpdateRib</param>
    /// <param name="ammount">ammount</param>
    /// <param name="operationType">operationType</param>
    void UpdateAccount(string accountToUpdateRib, double ammount, OperationType operationType);

    /// <summary>
    /// Get Account by RIB.
    /// </summary>
    /// <param name="rib">rib</param>
    /// <returns>Account</returns>
    Account GetAccountByRib(string rib);

    /// <summary>
    /// Get Account History.
    /// </summary>
    /// <param name="rib">rib</param>
    /// <returns>Account</returns>
    Account GetAccountHistory(string rib);
}