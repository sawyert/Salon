using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices
{
    public interface IDbTransaction
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
    }
}
