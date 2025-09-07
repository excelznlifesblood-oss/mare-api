using MessagePack;

namespace ShoninSync.API.Data;

[MessagePackObject(keyAsPropertyName: true)]
public record UserData(string UID, string? Alias = null, bool isLimited = false)
{
    [IgnoreMember]
    public string AliasOrUID => string.IsNullOrWhiteSpace(Alias) ? UID : Alias;
}