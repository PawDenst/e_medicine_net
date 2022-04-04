using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visits.Web.Application.Commands
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Handle(T command);
    }
}
