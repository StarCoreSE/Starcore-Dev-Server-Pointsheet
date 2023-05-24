using Sandbox.ModAPI;
using VRage.Game;
using VRage.Game.Components;

namespace ShipPoints
{
	[MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    class PointAdditions : MySessionComponentBase
    {
        public override void Init(MyObjectBuilder_SessionComponent sessionComponent)
        {
            MyAPIGateway.Utilities.SendModMessage(2546247, MyAPIGateway.Utilities.SerializeToBinary(@"
				
				6InchTriple@200;
				381mmDualR@200;
				381mmDualNR@200;
				380mmMLE1935@400;
				15cmSKC28R@100;
				15cmSKC28NR@100;
				128mmL45@100;
				128mmSKC34@115;
				127mmMk12@200;
				127mmMk24@225;
				127mmMk32@250;
				127mmMk56@350;
				105mmTwin@100;
				152mmMLE1930NR@145;
				152mmMLE1930R@145;
				152mmMLE1936HA@200;
				PomPomMain@100;
				150mmCasemate@150;
				BoforTwinRemodel@95;
				BoforSingleRemodel@75;
				QuadBofor@150;
				TorpTestBuidl@350;
				16InchTriple@400;
				15cmTbtsKC36T@100;
				15cmTbtsKC36@100;
				AMP_HealGenerator@420;
				203mmTwin@225;
				203mmQuad@400;
				TorpBarbette@500;

            "));
        }
    }
}
