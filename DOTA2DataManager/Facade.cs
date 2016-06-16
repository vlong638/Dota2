using DOTA2DataBase.Objects.Entities;
using DOTA2DataManager.Configs;
using DOTA2DataManager.Utilities;
using System;
using System.Collections.Generic;
using VL.Common.Logger.Utilities;
using VL.Common.Protocol;
using VL.Common.Protocol.IService;

namespace DOTA2DataManager
{
    public class Facade
    {
        public static Dota2Context DataCotext { set; get; } = new Dota2Context(new DOTA2DbConfig(), new ProtocolConfig(), LoggerProvider.GetLog4netLogger("ServiceLog"));

        /// <summary>
        /// 创建队伍
        /// </summary>
        /// <param name="teamName">队伍名</param>
        /// <param name="teamNameAbbr">队伍名简称</param>
        /// <param name="mmr">匹配积分</param>
        /// <returns></returns>
        public static Result<TTeam> CreateTeam(string teamName, string teamNameAbbr, int mmr)
        {
            return ServiceDelegator.HandleSimpleTransactionEvent(DbHelper.DbNameOfDota2DataBase, (session) =>
            {
                Result<TTeam> result = new Result<TTeam>();
                TTeam team = new TTeam()
                {
                    TeamId = Guid.NewGuid(),
                    Name = teamName,
                    NameAbbr = teamNameAbbr,
                    MMR = mmr,
                };
                if (team.CheckExistenceByName(session))
                {
                    result.ResultCode = EResultCode.Failure;
                    result.Message = "队伍名称已存在";
                }
                if (team.DbInsert(session))
                {
                    result.ResultCode = EResultCode.Success;
                    result.Message = "创建对象成功";
                    result.SubResultCode = team;
                }
                else
                {
                    result.ResultCode = EResultCode.Failure;
                    result.Message = "创建对象失败";
                }
                return result;
            });
        }
        /// <summary>
        /// 创建选手
        /// </summary>
        /// <param name="playerName">选手名称</param>
        /// <param name="playerNameAbbr">选手别名</param>
        /// <returns></returns>
        public static Result<TPlayer> CreatePlayer(string playerName, string playerNameAbbr)
        {
            return ServiceDelegator.HandleSimpleTransactionEvent(DbHelper.DbNameOfDota2DataBase, (session) =>
            {
                Result<TPlayer> result = new Result<TPlayer>();
                TPlayer player = new TPlayer()
                {
                    PlayerId = Guid.NewGuid(),
                    Name = playerName,
                    NameAbbr = playerNameAbbr,
                };
                if (player.DbInsert(session))
                {
                    result.ResultCode = EResultCode.Success;
                    result.Message = "创建对象成功";
                    result.SubResultCode = player;
                }
                else
                {
                    result.ResultCode = EResultCode.Failure;
                    result.Message = "创建对象失败";
                }
                return result;
            });
        }

        /// <summary>
        /// 获取队伍列表
        /// </summary>
        public static Result<List<TTeam>> SelectTeams()
        {
            return ServiceDelegator.HandleSimpleTransactionEvent(DbHelper.DbNameOfDota2DataBase, (session) =>
            {
                Result<List<TTeam>> result = new Result<List<TTeam>>();
                List<TTeam> teams = new List<TTeam>().DbSelect(session);
                result.ResultCode = EResultCode.Success;
                result.Message = "创建对象成功";
                result.SubResultCode = teams;
                return result;
            });
        }
        /// <summary>
        /// 获取选手列表
        /// </summary>
        public static Result<List<TPlayer>> SelectPlayers()
        {
            return ServiceDelegator.HandleSimpleTransactionEvent(DbHelper.DbNameOfDota2DataBase, (session) =>
            {
                Result<List<TPlayer>> result = new Result<List<TPlayer>>();
                List<TPlayer> players = new List<TPlayer>().DbSelect(session);
                result.ResultCode = EResultCode.Success;
                result.Message = "创建对象成功";
                result.SubResultCode = players;
                return result;
            });
        }
    }
}
