namespace Kinopoisk.Types;

[JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
public class ExternalId
{
    [JsonProperty("kpHD", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string? KinopoiskHd { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string? Imdb { get; set; }

    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string? Tmdb { get; set; }
}




