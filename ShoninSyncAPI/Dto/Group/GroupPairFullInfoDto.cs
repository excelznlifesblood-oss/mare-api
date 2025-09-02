using ShoninSync.API.Data;
using ShoninSync.API.Data.Enum;
using MessagePack;

namespace ShoninSync.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairFullInfoDto(GroupData Group, UserData User, UserPermissions SelfToOtherPermissions, UserPermissions OtherToSelfPermissions) : GroupPairDto(Group, User);