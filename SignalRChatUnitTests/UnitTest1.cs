using System;
using Xunit;
using SignalRChat.Hubs;
using System.Threading.Tasks;

namespace SignalRChatUnitTests
{
    public class SignalRHubsTest
    {
        [Fact]
        public async Task SendMessage_InCaseAllNull_Test()
        {
            var ch = new ChatHub();

            var ex = await Assert.ThrowsAnyAsync<ArgumentNullException>(() =>
            {
                return ch.SendMessage(null, null);
            });

            ex = await Assert.ThrowsAnyAsync<ArgumentNullException>(() =>
            {
                return ch.SendMessage(null, "");
            });
            ex = await Assert.ThrowsAnyAsync<ArgumentNullException>(() =>
            {
                return ch.SendMessage("", "");
            });
        }
    }
}
