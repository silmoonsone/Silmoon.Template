using Newtonsoft.Json.Linq;
using Silmoon.Extension;

namespace Silmoon.AspNetCore.FullTemplate;

public class Configure
{
    public static string ProjectName { get; set; }

    private static JObject configJson;
    public static JObject ConfigJson => configJson ??= GetJsonConfig();
    static JObject GetJsonConfig()
    {
#if DEBUG
        var json = JsonHelperV2.LoadJsonFromFile(@"config.debug.json");
#else
        var json = JsonHelperV2.LoadJsonFromFile(@"config.json");
#endif
        return json;
    }

    //public static string greCaptchaServerKey => ConfigJson["section"]["key"].Value<string>();

}
