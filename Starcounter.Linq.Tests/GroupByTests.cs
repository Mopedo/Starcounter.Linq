using System.Linq;
using Xunit;
using static Starcounter.Linq.Tests.Utils;
using static Starcounter.Linq.DbLinq;

namespace Starcounter.Linq.Tests
{
    public class GroupByTests
    {
        [Fact]
        public void GroupBy()
        {
            Assert.Equal("SELECT P FROM Starcounter.Linq.Tests.Person P GROUP BY P.Age",
                Sql<Person, int>(() => Objects<Person>().GroupBy(x => x.Age)));
        }
    }
}