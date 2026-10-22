using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatan.Enums
{
    public enum ResourceType
    {
        Wheat,
        Clay,
        Wood,
        Wool,
        Stone
    }

    public enum ConstructionType
    {
        Settlement,
        Town,
        Road
    }

    public enum RequestResult
    {
        Success,
        Failure
    }

    public enum RequestType
    {
        BuildSettlement,
        BuildTown,
        BuildRoad,
        TradeResources,
        PurchaseDevelopmentCard,
        MoveRobber,
        DiscardResources,
        PlayDevelopmentCard
    }

    public enum TradingType
    {
        PlayerToPlayer,
        PlayerToBank,
        PlayerToPort,
        PlayerToSpecalPort
    }

    public enum FieldType
    {
        Field,
        Hill,
        Mountain,
        Pasture,
        Forest,
        Dessert,
        Water
    }
}