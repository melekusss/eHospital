namespace Prescriptions.Web.Application.Commands
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Input;

    public interface ICommandHandler<T> where T : ICommand
    {
        void Handle(T command);
    }
}
