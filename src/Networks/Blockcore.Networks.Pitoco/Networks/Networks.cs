using Blockcore.Networks;

namespace Blockcore.Networks.Pitoco.Networks
{
   public static class Networks
   {
      public static NetworksSelector Pitoco
      {
         get
         {
            return new NetworksSelector(() => new PitocoMain(), () => new PitocoTest(), () => new PitocoRegTest());
         }
      }
   }
}
