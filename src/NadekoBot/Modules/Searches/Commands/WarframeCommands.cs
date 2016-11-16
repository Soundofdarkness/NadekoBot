using Discord;
using Discord.Commands;
using NadekoBot.Attributes;
using NadekoBot.Modules.Searches.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace NadekoBot.Modules.Searches
{
    public partial class Searches
    {
        [Group]
        public class WarframeCommands
        {
            private static Dictionary<string, WarframeModel> warframe = new Dictionary<string, WarframeModel>();

            public const string warframePC = "http://content.warframe.com/dynamic/worldState.php";

            private Logger _log;

            public WarframeCommands()
            {
                _log = LogManager.GetCurrentClassLogger();
                string response;
                using (var http = new HttpClient())
                    response = http.GetStringAsync($"{warframePC}").ToString();

                var obj = JObject.Parse(response);

                try
                {
                    warframe = JsonConvert.DeserializeObject<Dictionary<string, WarframeModel>>(obj.ToString());
                } catch
                {
                    _log.Warn("Could not reach Warframe [PC] API.");
                }
            }
        }
    }
}
