if DB_ID('SubRosa') is not NULL
    drop database SubRosa
GO

create database SubRosa
go

Use [SubRosa]
GO

create table dbo.Player
(
    PlayerId int IDENTITY(1,1) primary key,
    UserName varchar(100) not null,
    DisplayName nvarchar(100) not null,
    Image nvarchar(1000),
    Password nvarchar(1000)
)

create table dbo.Game
(
    GameId int IDENTITY(1,1) PRIMARY key,
    Name varchar(50),
    Code varchar(10),
    RoundNumber int,
    HostPlayerId int not null,
    GameStateId int not null,
    ElectionTracker int,
    WinningMembershipId int,
    CurrentPresidentPlayerId int,
    CurrentChancellorPlayerId int,
    TotalLiberalPolicies int not null,
    TotalFascistPolicies int not null,
    TotalLiberalPlayers int not null,
    TotalFascistPlayers int not null
)

create table dbo.GamePlayer
(
    GamePlayerId int IDENTITY(1,1) PRIMARY KEY,
    GameId int not null,
    PlayerId int not null,
    IsReadToStart bit,
    MembershipId int  not null,
    MembershipRoleId int  not null,
    IsExecuted bit,
    ElectionVote int
)

create table dbo.Government
(
    GovernmentId int IDENTITY(1,1) PRIMARY KEY,
    GameId int  not null,
    RoundNumber int not null,
    PresidentPlayerId int not null,
    ChancellorPlayerId int not null,
    GovernmentOutcomeId int not null,
    ExecutivePowerGranted int not null,
    ExecutivePowerUserOnPlayerId int
)

create table dbo.GovernmentOutcome
(
    GovernmentOutcomeId int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(100)  not null,
    Description nvarchar(1000),
    IsActive bit not null,
    Style nvarchar(1000),
    Image nvarchar(1000)
)

-- insert into dbo.GovernmentOutcome
--     ([Name], [Description], IsActive, Style, [Image])
-- VALUES
--     ('Failed','Government failed to establish by not winning majority vote.',1,null, null),
--     ('Liberal Policy','A liberal policy was enacted by the government.',1,null, null),
--     ('Fascist Policy','A fascist policy was enacted by the government.',1,null, null),
--     ('Veto Proposed - Declined','The chancellor proposed a veto but the president did not agree.',1,null, null),
--     ('Veto Proposed - Approved','The chancellor proposed a veto and the president did agreed.',1,null, null)

create table dbo.ElectionVote
(
    ElectionVoteId INT IDENTITY(1,1) PRIMARY KEY,
    Name varchar(100)  not null,
    Description nvarchar(1000),
    IsActive bit not null,
    Style nvarchar(1000),
    Image nvarchar(1000),
    InFavor int
)

-- insert into dbo.ElectionVote
--     ([Name], [Description], IsActive, Style, [Image],InFavor)
-- VALUES
--     ('Ya','Yes',1,null, null, 1),
--     ('Nein','No',1,null, null, 0)

create table dbo.GameStateId
(
    GameStateId INT IDENTITY(1,1) PRIMARY KEY,
    Name varchar(100)  not null,
    Description nvarchar(1000),
    IsActive bit not null,
    Style nvarchar(1000),
    Image nvarchar(1000)
)


create table dbo.Membership
(
    MembershipId int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(100)  not null,
    Description nvarchar(1000),
    IsActive bit not null,
    Style nvarchar(1000),
    Image nvarchar(1000)
)

create table dbo.MembershipRoleId
(
    MembershipRoleId int IDENTITY(1,1) PRIMARY KEY,
    MembershipId int not null,
    Name varchar(100)  not null,
    Description nvarchar(1000),
    IsActive bit not null,
    Style nvarchar(1000),
    Image nvarchar(1000)
)

create table dbo.Configuration
(
    ConfigurationId int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(100) not null,
    TotalPlayers int not null,
    TotalLiberalPlayers int not null,
    TotalFascistPlayers int not null,
    FascistBoard nvarchar(1000) not null,
    ExecutivePower1 int not null,
    ExecutivePower2 int not null,
    ExecutivePower3 int not null,
    ExecutivePower4 int not null,
    ExecutivePower5 int not null,
)

create table dbo.ExecutivePower
(
    ExecutivePowerId int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(100)  not null,
    Description nvarchar(1000),
    IsActive bit not null,
    Style nvarchar(1000),
    Image nvarchar(1000)
)

