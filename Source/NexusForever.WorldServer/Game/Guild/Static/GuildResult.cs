﻿namespace NexusForever.WorldServer.Game.Guild.Static
{
    public enum GuildResult
    {
        Success,
        AtMaxGuildCount,
        InvalidEmblemSelected,
        InvalidGuildName,
        NotInAGuild,
        RankLacksSufficientPermissions,
        UnknownCharacter,
        CharacterCannotJoinMoreGuilds,
        CharacterAlreadyHasAGuildInvite,
        CharacterInvited,
        GuildmasterCannotLeaveGuild,
        CharacterNotInYourGuild,
        CannotKickHigherOrEqualRankedMember,
        KickedMember,
        NoPendingInvites,
        PendingInviteExpired,
        CannotPromoteMemberAboveYourRank,
        PromotedToGuildMaster,
        PromotedMember,
        CanOnlyDemoteLowerRankedMembers,
        MemberIsAlreadyLowestRank,
        DemotedMember,
        InvalidRank,
        InvalidRankName,
        CanOnlyDeleteEmptyRanks,
        VoteAlreadyInProgress,
        AlreadyCastAVote,
        InvalidElection,
        VoteFailedToPass,
        NoVoteInProgress,
        MemberAlreadyGuildMaster,
        VoteStarted,
        InviteAccepted,
        InviteDeclined,
        GuildNameUnavailable,
        GuildDisbanded,
        RankModified,
        RankCreated,
        RankDeleted,
        UnableToProcess,
        MemberQuit,
        Voted,
        VotePassed,
        GuildLoading,
        KickedYou,
        CanOnlyModifyRanksBelowYours,
        YouQuit,
        YouJoined,
        RankRenamed,
        MemberOnline,
        MemberOffline,
        CannotInviteGuildFull,
        VoteTooRecentToHaveAnother,
        NotInThatGuild,
        InvalidFlags,
        AtMaxCircleCount,
        EmblemChanged,
        EmblemColorChanged,
        StandardChanged,
        NotAGuild,
        InvalidStandard,
        YouCreated,
        MaxWarPartyCount,
        VendorOutOfRange,
        NotABankTab,
        BankerOutOfRange,
        NoBank,
        BankTabAlreadyLoaded,
        NoBankItemSelected,
        BankItemMoved,
        RankLacksRankRenamePermission,
        InvalidBankTabName,
        CannotWithdrawBankItem,
        BankTabNotLoaded,
        CannotDepositBankItem,
        MaxArenaTeamCount,
        AlreadyAMember,
        BankTabWithdrawsExceeded,
        BankTabNotVisible,
        BankTabDoesNotAcceptDeposits,
        BankTabRequiresAuthenticator,
        BankTabCannotWithdraw,
        InsufficientInfluence,
        RequiresPrereq,
        BankTabBought,
        ExceededMoneyWithdrawLimitToday,
        InsufficientMoneyInGuild,
        InsufficientMoneyOnCharacter,
        NotEnoughRenown,
        InvalidEmblemColorSelected,
        CannotDisbandTeamWithActiveGame,
        CannotLeaveTeamWithActiveGame,
        CannotRemoveFromTeamWithActiveGame,
        InsufficientWarCoins,
        PerkDoesNotExist,
        PerkIsAlreadyUnlocked,
        RequiresPerkPurchase,
        PerkNotActivateable,
        CannotModifyResidenceWithActiveGame,
        NotHighEnoughLevel,
        GenericActiveGameFailure,
        CannotChangeRanksWithActiveGame,
        CannotChangePermissionsWithActiveGame,
        CannotEditBankWithActiveGame,
        InvalidMessageOfTheDay,
        InvalidMemberNote,
        InsufficentMembers,
        NotAWarParty,
        RequiresAchievement,
        NotAValidWarPartyItem,
        InvalidGuildRecruitDescription,
        UnusableGuildRecruitDescription,
        InvalidGuildInfo,
        NotEnoughCredits,
        CannotDeleteDefaultRanks                 = 115,
        DuplicateRankName,
        InviteSent,
        BankTabInvalidPermissions,
        Busy,
        PerkIsAlreadyActive,
        CannotCreateWhileInQueue,
        PrivilegeRestricted,
        AtMaxCommunityCount,
        MustBeHomeowner,
        CharacterNotAHomeowner,
        RenameNotAvailable,
        InviteRestrictedNoEntitlement,
        ExceedsMoneyTradeLimit
    }
}
