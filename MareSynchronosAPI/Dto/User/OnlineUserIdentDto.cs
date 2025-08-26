using ShoninSync.API.Data;
using MessagePack;

namespace ShoninSync.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record OnlineUserIdentDto(UserData User, string Ident) : UserDto(User);