using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Web.Tests.Unit.HelperTests
{
    public class TestOptionsManager<TOptions> : IOptions<TOptions>
        where TOptions : class, new()
    {
        public TestOptionsManager()
            : this(new TOptions())
        {
        }

        public TestOptionsManager(TOptions value)
        {
            Value = value;
        }

        public TOptions Value { get; }
    }
}
