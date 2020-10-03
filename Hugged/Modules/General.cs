using Discord;
using Discord.Commands;
using System;
using System.Threading.Tasks;
namespace General
{
    public class General : ModuleBase
    {
        [Command("level")]
        [Alias("lvl", "lev")]
        public async Task LevelAsync(string UserId, int GuildMsgs)
        {
            try
            {
                IMessageChannel message = (IMessageChannel)Context.Channel.GetMessagesAsync(GuildMsgs);
                var msg = await message.GetUserAsync(ulong.Parse(UserId));
                var e = new EmbedBuilder();
                e.WithDescription($"**Your Hug Level is {msg}**");
                e.WithColor(4360181);

                await ReplyAsync(embed: e.Build());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            {

            }
        }
        [Command("Source")]
        public async Task SourceAsync()
        {
            await ReplyAsync("You can view my source code at http://github.com/Faith1sGay/Hugged.");
        }
    }
}