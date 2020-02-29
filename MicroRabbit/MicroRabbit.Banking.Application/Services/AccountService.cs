using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;

        public AccountService(IAccountRepository accountRepository,
            IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<Accounts> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void TransferFunds(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount, 
                accountTransfer.ToAccount, 
                accountTransfer.TransferForAmount
                );

            _eventBus.SendCommand(createTransferCommand);
        }
    }
}
