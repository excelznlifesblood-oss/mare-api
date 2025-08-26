using ShoninSync.API.Data;
using MessagePack;

namespace ShoninSync.API.Dto.CharaData;

[MessagePackObject(keyAsPropertyName: true)]
public record CharaDataMetaInfoDto(string Id, UserData Uploader) : CharaDataDto(Id, Uploader)
{
    public bool CanBeDownloaded { get; init; }
    public List<PoseEntry> PoseData { get; set; } = [];
}
