/** @author Epyi */

namespace Sandbox.Mirage.Vehicles;

/// <summary>
/// Slip-vs-force curve used by <see cref="MirageWheel"/> for both forward
/// and side friction. Ported from the VehicleSystemExemple repo so a
/// dropped-in vehicle prefab can keep the same drive feel out of the box.
/// </summary>
public struct MirageWheelFrictionInfo
{
	public float ExtremumSlip { get; set; }
	public float ExtremumValue { get; set; }
	public float AsymptoteSlip { get; set; }
	public float AsymptoteValue { get; set; }
	public float Stiffness { get; set; }

	public MirageWheelFrictionInfo()
	{
		ExtremumSlip = 1.0f;
		ExtremumValue = 20000.0f;
		AsymptoteSlip = 2.0f;
		AsymptoteValue = 10000.0f;
		Stiffness = 1.0f;
	}

	public float Evaluate( float slip )
	{
		float value;
		if ( slip <= ExtremumSlip )
		{
			value = (slip / ExtremumSlip) * ExtremumValue;
		}
		else
		{
			value = ExtremumValue - ((slip - ExtremumSlip) / (AsymptoteSlip - ExtremumSlip)) * (ExtremumValue - AsymptoteValue);
		}
		return (value * Stiffness).Clamp( 0, float.MaxValue );
	}
}
