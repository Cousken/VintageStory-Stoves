using System;
using System.Reflection;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace Vintagestory.Stoves
{
    public class BlockClayStove : Block
    {
        public BlockClayStove()
        {
            Console.WriteLine("Creating a [stove]");
        }

        public override void OnLoaded(ICoreAPI api)
        {
            Console.WriteLine("[stoves]");
            base.OnLoaded(api);
        }

        public override EnumIgniteState OnTryIgniteBlock(EntityAgent byEntity, BlockPos pos, float secondsIgniting)
        {
            Console.WriteLine("[stoves]");
            return base.OnTryIgniteBlock(byEntity, pos, secondsIgniting);
        }

        public override void OnTryIgniteBlockOver(EntityAgent byEntity, BlockPos pos, float secondsIgniting, ref EnumHandling handling)
        {
            Console.WriteLine("[stoves]");
            base.OnTryIgniteBlockOver(byEntity, pos, secondsIgniting, ref handling);
        }

        public override bool ShouldReceiveClientParticleTicks(IWorldAccessor world, IPlayer player, BlockPos pos, out bool isWindAffected)
        {
            Console.WriteLine("[stoves]");
            return base.ShouldReceiveClientParticleTicks(world, player, pos, out isWindAffected);
        }

        public override void OnAsyncClientParticleTick(IAsyncParticleManager manager, BlockPos pos, float windAffectednessAtPos, float secondsTicking)
        {
            Console.WriteLine("[stoves]");

            base.OnAsyncClientParticleTick(manager, pos, windAffectednessAtPos, secondsTicking);
        }

        public override bool OnBlockInteractStart(IWorldAccessor world, IPlayer byPlayer, BlockSelection blockSel)
        {
            Console.WriteLine("[stoves]");
            return base.OnBlockInteractStart(world, byPlayer, blockSel);
        }

        public override WorldInteraction[] GetPlacedBlockInteractionHelp(IWorldAccessor world, BlockSelection selection, IPlayer forPlayer)
        {
            Console.WriteLine("[stoves]");
            return base.GetPlacedBlockInteractionHelp(world, selection, forPlayer);
        }
    }
}
