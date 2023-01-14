using Vintagestory.API.Common;
using Vintagestory.Stoves;

namespace stoves
{
    public class StoveMod : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);

            api.RegisterBlockClass("claystove", typeof(BlockClayStove));
            api.RegisterBlockEntityClass("claystoveblockentity", typeof(BlockEntityClayStove));
        }
    }
}
