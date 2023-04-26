namespace MessageLogger.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Message_GetsCreated()
        {
            Message newMessage = new Message("");
            Assert.Equal("", newMessage.Content);
        }
        [Fact]
        public void Message_SaveMessage_SavesMessage()
        {
            Message newMessage = new Message("");
        }
    }
}