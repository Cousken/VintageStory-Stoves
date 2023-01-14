using System.Reflection;
using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace stoves
{
    public class BlockEntityClayStove: BlockEntityFirepit
    {
        private ILogger logger = null;

        public override void Initialize(ICoreAPI api)
        {
            logger = api.Logger;

            logger?.Debug("[stoves]" + MethodBase.GetCurrentMethod().Name);

            base.Initialize(api);
        }
    }
}
