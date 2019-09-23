namespace Burning.DofusProtocol.Enums
{
  public enum FighterRefusedReasonEnum
  {
    FIGHTER_REFUSED = -1, // 0xFFFFFFFF
    FIGHTER_ACCEPTED = 0,
    CHALLENGE_FULL = 1,
    TEAM_FULL = 2,
    WRONG_ALIGNMENT = 3,
    WRONG_GUILD = 4,
    TOO_LATE = 5,
    MUTANT_REFUSED = 6,
    WRONG_MAP = 7,
    JUST_RESPAWNED = 8,
    IM_OCCUPIED = 9,
    OPPONENT_OCCUPIED = 10, // 0x0000000A
    FIGHT_MYSELF = 11, // 0x0000000B
    INSUFFICIENT_RIGHTS = 12, // 0x0000000C
    MEMBER_ACCOUNT_NEEDED = 13, // 0x0000000D
    OPPONENT_NOT_MEMBER = 14, // 0x0000000E
    TEAM_LIMITED_BY_MAINCHARACTER = 15, // 0x0000000F
    MULTIACCOUNT_NOT_ALLOWED = 16, // 0x00000010
    GHOST_REFUSED = 17, // 0x00000011
    RESTRICTED_ACCOUNT = 19, // 0x00000013
    WRONG_ALLIANCE = 20, // 0x00000014
    AVA_ZONE = 21, // 0x00000015
    COMPANION_REFUSED = 22, // 0x00000016
    NOT_ENOUGH_ROOM = 23, // 0x00000017
    GUEST_ACCOUNT = 24, // 0x00000018
  }
}