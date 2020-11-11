using System;
using System.Collections.Generic;
using System.Text;

namespace Sisak.EfLearning.Dal
{
    public interface IDaoFactory
    {
        IPersonDao CreatePersonDao();
        IDeviceDao CreateDeviceDao();
    }
}
