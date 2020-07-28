using KDSevice;
using System;
using System.Collections.Generic;
using System.Text;
using KDControl;

namespace KDSevice
{
    public interface IContainerRepository: IRepository<SupervisorS>
    {
        public IEnumerable<Login> GetLogin();

    }
}
