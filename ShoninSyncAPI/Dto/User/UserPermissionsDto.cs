using ShoninSync.API.Data;
using ShoninSync.API.Data.Enum;
using MessagePack;

namespace ShoninSync.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserPermissionsDto(UserData User, UserPermissions Permissions) : UserDto(User);
