using Moq.AutoMock;

namespace UnitTests.Base
{
    public class TestBase
    {
        protected AutoMocker Mocker;

        protected TestBase()
        {
            Mocker = new AutoMocker();
        }
    }
}
