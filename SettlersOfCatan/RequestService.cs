using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SettlersOfCatan.Enums;

namespace SettlersOfCatan
{
    public static class RequestService
    {
        public static GameState GameState { get; set; }
        public static Queue<(RequestType requestType, Guid playerID)> Requests { get; set; }

        public static void RegisterRequest(RequestType requestType, Guid playerID)
        {
            //make sure requests is not null
            if (Requests == null) 
                Requests = new Queue<(RequestType requestType, Guid playerID)>();

            Requests.Enqueue((requestType, playerID));
        }

        public static RequestResult ValidateCurrentRequest()
        {
            (RequestType requestType, Guid playerID) request = Requests.Dequeue();

            switch (request.requestType)
            {
                case RequestType.BuildSettlement:
                    return ValidateBuildingRequest(ConstructionType.Settlement, request.playerID);
                case RequestType.BuildTown:
                    return ValidateBuildingRequest(ConstructionType.Town, request.playerID);
                case RequestType.BuildRoad:
                    return ValidateBuildingRequest(ConstructionType.Road, request.playerID);
                case RequestType.PurchaseDevelopmentCard:
                    return ValidatePurchaseDevelopmentCardRequest(request.playerID);
                case RequestType.TradeResources:
                    throw new NotImplementedException("Trade validation is not implemented yet!");
                default:
                    throw new NotImplementedException("Invalid request type!");
            }
        }

        public static RequestResult ValidateBuildingRequest(ConstructionType constructionType, Guid playerID)
        {
            switch (constructionType)
            {
                case ConstructionType.Settlement:
                    if (CanBuildSettlement(playerID))
                        return RequestResult.Success;
                    else
                        return RequestResult.Failure;
                case ConstructionType.Town:
                    if (CanBuildTown(playerID))
                        return RequestResult.Success;
                    else
                        return RequestResult.Failure;
                case ConstructionType.Road:
                    if (CanBuildRoad(playerID))
                        return RequestResult.Success;
                    else
                        return RequestResult.Failure;
                default:
                    throw new NotImplementedException("Invalid construction type!");
            }
        }

        public static RequestResult ValidatePurchaseDevelopmentCardRequest(Guid playerID)
        {
            if (CanPurchaseDevelopmentCard(playerID))   
                return RequestResult.Success;
            else
                return RequestResult.Failure;
        }

        public static bool CanBuildSettlement(Guid playerID)
        {
            Player p;
            try
            {
                p = GameState.Players.Single(p => p.ID == playerID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
            if (p.Resources.Count(r => r == ResourceType.Wheat) > 0 &&
                p.Resources.Count(r => r == ResourceType.Wool) > 0 &&
                p.Resources.Count(r => r == ResourceType.Wood) > 0 &&
                p.Resources.Count(r => r == ResourceType.Clay) > 0)
                return true;
            else
                return false;
        }

        public static bool CanBuildTown(Guid playerID)
        {
            Player p;
            try
            {
                p = GameState.Players.Single(p => p.ID == playerID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            if (p.Resources.Count(r => r == ResourceType.Wheat) > 1 &&
                p.Resources.Count(r => r == ResourceType.Stone) > 2)
                return true;
            else
                return false;
        }

        public static bool CanBuildRoad(Guid playerID)
        {
            Player p;
            try
            {
                p = GameState.Players.Single(p => p.ID == playerID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            if (p.Resources.Count(r => r == ResourceType.Wood) > 0 &&
                p.Resources.Count(r => r == ResourceType.Clay) > 0)
                return true;
            else
                return false;
        }

        public static bool CanPurchaseDevelopmentCard(Guid playerID)
        {
            Player p;
            try
            {
                p = GameState.Players.Single(p => p.ID == playerID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            if (p.Resources.Count(r => r == ResourceType.Wheat) > 0 &&
                p.Resources.Count(r => r == ResourceType.Wool) > 0 &&
                p.Resources.Count(r => r == ResourceType.Stone) > 0)
                return true;
            else
                return false;
        }
    }
}
