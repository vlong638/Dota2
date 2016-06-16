
if exists (select 1
            from  sysobjects
           where  id = object_id('TEvent')
            and   type = 'U')
   drop table TEvent
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TEventReward')
            and   type = 'U')
   drop table TEventReward
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THero')
            and   type = 'U')
   drop table THero
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TMatch')
            and   type = 'U')
   drop table TMatch
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TMatchTeam')
            and   type = 'U')
   drop table TMatchTeam
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TPlayer')
            and   type = 'U')
   drop table TPlayer
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRound')
            and   type = 'U')
   drop table TRound
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRoundTeam')
            and   type = 'U')
   drop table TRoundTeam
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRoundTeamPlayer')
            and   type = 'U')
   drop table TRoundTeamPlayer
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TTeam')
            and   type = 'U')
   drop table TTeam
go

/*==============================================================*/
/* Table: TEvent                                                */
/*==============================================================*/
create table TEvent (
   EventId              uniqueidentifier     not null,
   Name                 nvarchar(40)         not null,
   NameAbbr             nvarchar(40)         not null,
   Bonus                nvarchar(40)         not null,
   constraint PK_TEVENT primary key (EventId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TEvent') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TEvent' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '赛事', 
   'user', @CurrentUser, 'table', 'TEvent'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TEvent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'EventId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TEvent', 'column', 'EventId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '赛事Id',
   'user', @CurrentUser, 'table', 'TEvent', 'column', 'EventId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TEvent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Name')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TEvent', 'column', 'Name'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '赛事名称',
   'user', @CurrentUser, 'table', 'TEvent', 'column', 'Name'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TEvent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NameAbbr')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TEvent', 'column', 'NameAbbr'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '赛事名称(缩写)',
   'user', @CurrentUser, 'table', 'TEvent', 'column', 'NameAbbr'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TEvent')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Bonus')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TEvent', 'column', 'Bonus'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '奖金情况',
   'user', @CurrentUser, 'table', 'TEvent', 'column', 'Bonus'
go

/*==============================================================*/
/* Table: TEventReward                                          */
/*==============================================================*/
create table TEventReward (
   EventId              uniqueidentifier     not null,
   Area                 nvarchar(40)         not null,
   Description          nvarchar(40)         not null,
   Bonus                nvarchar(40)         not null,
   constraint PK_TEVENTREWARD primary key (EventId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TEventReward') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TEventReward' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '赛事奖励', 
   'user', @CurrentUser, 'table', 'TEventReward'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TEventReward')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'EventId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TEventReward', 'column', 'EventId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '赛事Id',
   'user', @CurrentUser, 'table', 'TEventReward', 'column', 'EventId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TEventReward')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Area')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TEventReward', 'column', 'Area'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '获奖区间(如第一名,2-3...)',
   'user', @CurrentUser, 'table', 'TEventReward', 'column', 'Area'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TEventReward')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Description')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TEventReward', 'column', 'Description'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '描述(冠亚季,四五六等奖...)',
   'user', @CurrentUser, 'table', 'TEventReward', 'column', 'Description'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TEventReward')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Bonus')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TEventReward', 'column', 'Bonus'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '奖金情况',
   'user', @CurrentUser, 'table', 'TEventReward', 'column', 'Bonus'
go

/*==============================================================*/
/* Table: THero                                                 */
/*==============================================================*/
create table THero (
   HeroId               uniqueidentifier     not null,
   Name                 nvarchar(20)         not null,
   NameAbbr             nvarchar(20)         not null,
   constraint PK_THERO primary key (HeroId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('THero') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'THero' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '英雄', 
   'user', @CurrentUser, 'table', 'THero'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('THero')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'HeroId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'THero', 'column', 'HeroId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '选手Id',
   'user', @CurrentUser, 'table', 'THero', 'column', 'HeroId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('THero')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Name')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'THero', 'column', 'Name'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '选手名称',
   'user', @CurrentUser, 'table', 'THero', 'column', 'Name'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('THero')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NameAbbr')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'THero', 'column', 'NameAbbr'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '选手名称(缩写)',
   'user', @CurrentUser, 'table', 'THero', 'column', 'NameAbbr'
go

/*==============================================================*/
/* Table: TMatch                                                */
/*==============================================================*/
create table TMatch (
   EventId              uniqueidentifier     not null,
   MatchId              uniqueidentifier     not null,
   Name                 nvarchar(20)         not null,
   TeamIdOfWinner       uniqueidentifier     not null,
   constraint PK_TMATCH primary key (EventId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TMatch') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TMatch' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '对抗', 
   'user', @CurrentUser, 'table', 'TMatch'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TMatch')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'EventId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TMatch', 'column', 'EventId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '赛事Id',
   'user', @CurrentUser, 'table', 'TMatch', 'column', 'EventId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TMatch')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'MatchId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TMatch', 'column', 'MatchId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '对阵Id',
   'user', @CurrentUser, 'table', 'TMatch', 'column', 'MatchId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TMatch')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Name')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TMatch', 'column', 'Name'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '名称,描述(某Event第n轮)',
   'user', @CurrentUser, 'table', 'TMatch', 'column', 'Name'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TMatch')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TeamIdOfWinner')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TMatch', 'column', 'TeamIdOfWinner'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '胜者队',
   'user', @CurrentUser, 'table', 'TMatch', 'column', 'TeamIdOfWinner'
go

/*==============================================================*/
/* Table: TMatchTeam                                            */
/*==============================================================*/
create table TMatchTeam (
   MatchId              uniqueidentifier     not null,
   TeamId               uniqueidentifier     not null,
   constraint PK_TMATCHTEAM primary key (MatchId, TeamId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TMatchTeam') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TMatchTeam' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '参赛队', 
   'user', @CurrentUser, 'table', 'TMatchTeam'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TMatchTeam')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'MatchId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TMatchTeam', 'column', 'MatchId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '对阵Id',
   'user', @CurrentUser, 'table', 'TMatchTeam', 'column', 'MatchId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TMatchTeam')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TeamId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TMatchTeam', 'column', 'TeamId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '战队Id',
   'user', @CurrentUser, 'table', 'TMatchTeam', 'column', 'TeamId'
go

/*==============================================================*/
/* Table: TPlayer                                               */
/*==============================================================*/
create table TPlayer (
   PlayerId             uniqueidentifier     not null,
   Name                 nvarchar(20)         not null,
   NameAbbr             nvarchar(20)         not null,
   constraint PK_TPLAYER primary key (PlayerId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TPlayer') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TPlayer' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '选手', 
   'user', @CurrentUser, 'table', 'TPlayer'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TPlayer')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PlayerId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TPlayer', 'column', 'PlayerId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '选手Id',
   'user', @CurrentUser, 'table', 'TPlayer', 'column', 'PlayerId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TPlayer')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Name')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TPlayer', 'column', 'Name'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '选手名称',
   'user', @CurrentUser, 'table', 'TPlayer', 'column', 'Name'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TPlayer')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NameAbbr')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TPlayer', 'column', 'NameAbbr'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '选手名称(缩写)',
   'user', @CurrentUser, 'table', 'TPlayer', 'column', 'NameAbbr'
go

/*==============================================================*/
/* Table: TRound                                                */
/*==============================================================*/
create table TRound (
   EventId              uniqueidentifier     not null,
   MatchId              uniqueidentifier     not null,
   RoundId              uniqueidentifier     not null,
   RoundNumber          nvarchar(20)         not null,
   RoundStatus          numeric              not null,
   TeamIdOfWinner       uniqueidentifier     not null,
   constraint PK_TROUND primary key (RoundId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TRound') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TRound' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '回合', 
   'user', @CurrentUser, 'table', 'TRound'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRound')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'EventId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRound', 'column', 'EventId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '赛事Id',
   'user', @CurrentUser, 'table', 'TRound', 'column', 'EventId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRound')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'MatchId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRound', 'column', 'MatchId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '对阵Id',
   'user', @CurrentUser, 'table', 'TRound', 'column', 'MatchId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRound')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'RoundId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRound', 'column', 'RoundId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '回合Id',
   'user', @CurrentUser, 'table', 'TRound', 'column', 'RoundId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRound')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'RoundNumber')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRound', 'column', 'RoundNumber'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '回合号',
   'user', @CurrentUser, 'table', 'TRound', 'column', 'RoundNumber'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRound')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'RoundStatus')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRound', 'column', 'RoundStatus'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '回合进行状态',
   'user', @CurrentUser, 'table', 'TRound', 'column', 'RoundStatus'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRound')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TeamIdOfWinner')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRound', 'column', 'TeamIdOfWinner'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '胜者队',
   'user', @CurrentUser, 'table', 'TRound', 'column', 'TeamIdOfWinner'
go

/*==============================================================*/
/* Table: TRoundTeam                                            */
/*==============================================================*/
create table TRoundTeam (
   RoundId              uniqueidentifier     not null,
   TeamId               uniqueidentifier     not null,
   Side                 numeric              not null,
   BP                   varchar(200)         not null,
   constraint PK_TROUNDTEAM primary key (RoundId, TeamId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TRoundTeam') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TRoundTeam' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '参赛队回合', 
   'user', @CurrentUser, 'table', 'TRoundTeam'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeam')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'RoundId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeam', 'column', 'RoundId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '回合Id',
   'user', @CurrentUser, 'table', 'TRoundTeam', 'column', 'RoundId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeam')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TeamId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeam', 'column', 'TeamId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '战队Id',
   'user', @CurrentUser, 'table', 'TRoundTeam', 'column', 'TeamId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeam')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Side')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeam', 'column', 'Side'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '阵营',
   'user', @CurrentUser, 'table', 'TRoundTeam', 'column', 'Side'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeam')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'BP')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeam', 'column', 'BP'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '办选人',
   'user', @CurrentUser, 'table', 'TRoundTeam', 'column', 'BP'
go

/*==============================================================*/
/* Table: TRoundTeamPlayer                                      */
/*==============================================================*/
create table TRoundTeamPlayer (
   RoundId              uniqueidentifier     not null,
   TeamId               uniqueidentifier     not null,
   PlayerId             uniqueidentifier     not null,
   HeroId               uniqueidentifier     not null,
   KDA                  numeric              not null,
   KDADetail            varchar(20)          not null,
   GPM                  numeric              not null,
   XPM                  numeric              not null,
   IsGodLike            boolean              null,
   constraint PK_TROUNDTEAMPLAYER primary key (RoundId, TeamId, PlayerId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TRoundTeamPlayer') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '回合期间成员明细', 
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeamPlayer')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'RoundId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'RoundId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '回合Id',
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'RoundId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeamPlayer')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TeamId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'TeamId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '战队Id',
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'TeamId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeamPlayer')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'PlayerId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'PlayerId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '选手Id',
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'PlayerId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeamPlayer')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'HeroId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'HeroId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '英雄Id',
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'HeroId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeamPlayer')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'KDA')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'KDA'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '人头贡献比',
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'KDA'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeamPlayer')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'KDADetail')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'KDADetail'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '人头贡献比明细',
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'KDADetail'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeamPlayer')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'GPM')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'GPM'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '经济分钟',
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'GPM'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeamPlayer')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'XPM')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'XPM'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '经验分钟',
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'XPM'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TRoundTeamPlayer')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'IsGodLike')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'IsGodLike'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '是否超神',
   'user', @CurrentUser, 'table', 'TRoundTeamPlayer', 'column', 'IsGodLike'
go

/*==============================================================*/
/* Table: TTeam                                                 */
/*==============================================================*/
create table TTeam (
   TeamId               uniqueidentifier     not null,
   Name                 nvarchar(20)         not null,
   NameAbbr             nvarchar(20)         not null,
   MMR                  numeric              not null,
   constraint PK_TTEAM primary key (TeamId)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('TTeam') and minor_id = 0)
begin 
   declare @CurrentUser sysname 
select @CurrentUser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'user', @CurrentUser, 'table', 'TTeam' 
 
end 


select @CurrentUser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   '战队', 
   'user', @CurrentUser, 'table', 'TTeam'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TTeam')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'TeamId')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TTeam', 'column', 'TeamId'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '战队Id',
   'user', @CurrentUser, 'table', 'TTeam', 'column', 'TeamId'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TTeam')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'Name')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TTeam', 'column', 'Name'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '战队名称',
   'user', @CurrentUser, 'table', 'TTeam', 'column', 'Name'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TTeam')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'NameAbbr')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TTeam', 'column', 'NameAbbr'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '战队名称(缩写)',
   'user', @CurrentUser, 'table', 'TTeam', 'column', 'NameAbbr'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('TTeam')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'MMR')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'TTeam', 'column', 'MMR'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '比赛匹配分级',
   'user', @CurrentUser, 'table', 'TTeam', 'column', 'MMR'
go
