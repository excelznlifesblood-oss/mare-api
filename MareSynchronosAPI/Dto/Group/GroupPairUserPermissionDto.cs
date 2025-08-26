using ShoninSync.API.Data;
using ShoninSync.API.Data.Enum;
using MessagePack;

namespace ShoninSync.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserPermissionDto(GroupData Group, UserData User, GroupUserPreferredPermissions GroupPairPermissions) : GroupPairDto(Group, User);