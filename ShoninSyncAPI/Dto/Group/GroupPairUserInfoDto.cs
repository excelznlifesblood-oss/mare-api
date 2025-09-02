using ShoninSync.API.Data;
using ShoninSync.API.Data.Enum;
using MessagePack;

namespace ShoninSync.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserInfoDto(GroupData Group, UserData User, GroupPairUserInfo GroupUserInfo) : GroupPairDto(Group, User);