using ShoninSync.API.Data;
using ShoninSync.API.Data.Enum;
using MessagePack;

namespace ShoninSync.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserIndividualPairStatusDto(UserData User, IndividualPairStatus IndividualPairStatus) : UserDto(User);