using System;
using System.Collections.Generic;
using System.Text;

namespace Sisak.EfLearning.Client
{
    internal class Configuration
    {
        public class _ConnectionStrings
        {
            public string Default { get; set; }
        }

        public _ConnectionStrings ConnectionStrings { get; set; }
    }
}
