﻿// VRTracker System|SDK_VRTracker|002
namespace VRTK
{
    /// <summary>
	/// The VRTracker System SDK script provides a bridge to the Oculus SDK.
    /// </summary>
	[SDK_Description("VRTracker (Oculus)", SDK_XimmerseDefines.ScriptingDefineSymbol, "Oculus", "Standalone")]
	[SDK_Description("VRTracker (SteamVR)", SDK_SteamVRDefines.ScriptingDefineSymbol, "OpenVR", "Standalone", 1)]
	[SDK_Description("VRTracker (Daydream)", SDK_XimmerseDefines.ScriptingDefineSymbol, "Daydream", "Android", 2)]
	public class SDK_VRTrackerSystem
#if VRTK_DEFINE_SDK_VRTRACKER
        : SDK_BaseSystem
#else
        : SDK_FallbackSystem
#endif
    {
#if VRTK_DEFINE_SDK_VRTRACKER
        /// <summary>
        /// The IsDisplayOnDesktop method returns true if the display is extending the desktop.
        /// </summary>
        /// <returns>Returns true if the display is extending the desktop</returns>
        public override bool IsDisplayOnDesktop()
        {
            return false;
        }

        /// <summary>
        /// The ShouldAppRenderWithLowResources method is used to determine if the Unity app should use low resource mode. Typically true when the dashboard is showing.
        /// </summary>
        /// <returns>Returns true if the Unity app should render with low resources.</returns>
        public override bool ShouldAppRenderWithLowResources()
        {
            return false;
        }

        /// <summary>
        /// The ForceInterleavedReprojectionOn method determines whether Interleaved Reprojection should be forced on or off.
        /// </summary>
        /// <param name="force">If true then Interleaved Reprojection will be forced on, if false it will not be forced on.</param>
        public override void ForceInterleavedReprojectionOn(bool force)
        {
        }
#endif
    }
}