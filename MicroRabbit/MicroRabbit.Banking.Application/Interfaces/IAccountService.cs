using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Accounts> GetAccounts();
        void TransferFunds(AccountTransfer accountTransfer);
    }
}
