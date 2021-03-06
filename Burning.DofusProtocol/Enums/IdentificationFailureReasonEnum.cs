namespace Burning.DofusProtocol.Enums
{
  public enum IdentificationFailureReasonEnum
  {
    BAD_VERSION = 1,
    WRONG_CREDENTIALS = 2,
    BANNED = 3,
    KICKED = 4,
    IN_MAINTE0CE = 5,
    TOO_MANY_ON_IP = 6,
    TIME_OUT = 7,
    BAD_IPRANGE = 8,
    CREDENTIALS_RESET = 9,
    EMAIL_UNVALIDATED = 10, // 0x0000000A
    OTP_TIMEOUT = 11, // 0x0000000B
    LOCKED = 12, // 0x0000000C
    SERVICE_UNAVAILABLE = 53, // 0x00000035
    EXTERNAL_ACCOUNT_LINK_REFUSED = 61, // 0x0000003D
    EXTERNAL_ACCOUNT_ALREADY_LINKED = 62, // 0x0000003E
    UNKNOWN_AUTH_ERROR = 99, // 0x00000063
    SPARE = 100, // 0x00000064
  }
}
