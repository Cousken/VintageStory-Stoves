using System;
using System.Reflection;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace Vintagestory.Stoves
{
    public class BlockClayStove : BlockFirepit
    {
        private ILogger logger = null;


        public BlockClayStove()
        {

            logger?.Debug("Creating a [stove]");
        }

        public override void OnLoaded(ICoreAPI api)
        {
            logger = api.Logger;

            logger?.Debug("[stoves]" + MethodBase.GetCurrentMethod().Name);

            base.OnLoaded(api);
        }

        public override EnumIgniteState OnTryIgniteBlock(EntityAgent byEntity, BlockPos pos, float secondsIgniting)
        {
            logger?.Debug("[stoves]" + MethodBase.GetCurrentMethod().Name);
            return base.OnTryIgniteBlock(byEntity, pos, secondsIgniting);
        }

        public override void OnTryIgniteBlockOver(EntityAgent byEntity, BlockPos pos, float secondsIgniting, ref EnumHandling handling)
        {
            logger?.Debug("[stoves]" + MethodBase.GetCurrentMethod().Name);
            base.OnTryIgniteBlockOver(byEntity, pos, secondsIgniting, ref handling);
        }

        public override bool ShouldReceiveClientParticleTicks(IWorldAccessor world, IPlayer player, BlockPos pos, out bool isWindAffected)
        {
            logger?.Debug("[stoves]" + MethodBase.GetCurrentMethod().Name);
            return base.ShouldReceiveClientParticleTicks(world, player, pos, out isWindAffected);
        }

        public override void OnAsyncClientParticleTick(IAsyncParticleManager manager, BlockPos pos, float windAffectednessAtPos, float secondsTicking)
        {
            logger?.Debug("[stoves]" + MethodBase.GetCurrentMethod().Name);

            base.OnAsyncClientParticleTick(manager, pos, windAffectednessAtPos, secondsTicking);
        }

        public override bool OnBlockInteractStart(IWorldAccessor world, IPlayer byPlayer, BlockSelection blockSel)
        {
            logger?.Debug("[stoves]" + MethodBase.GetCurrentMethod().Name);
            return base.OnBlockInteractStart(world, byPlayer, blockSel);
        }

        public override WorldInteraction[] GetPlacedBlockInteractionHelp(IWorldAccessor world, BlockSelection selection, IPlayer forPlayer)
        {
            logger?.Debug("[stoves]" + MethodBase.GetCurrentMethod().Name + MethodBase.GetCurrentMethod().Name);
            return base.GetPlacedBlockInteractionHelp(world, selection, forPlayer);
        }
    }
}
