// #name Graphics.Shadows
// #author NathanLithia
// #desc Sets Graphics options.

using UnityEngine;

public static class ShadowsMod {
    public static void Main() {
        // Set if shadows are on or off
        bool ShadowsEnabled = true;

        if (ShadowsEnabled == true) {
            Debug.Log("ShadowsMod: Shadows are set to Enabled.");
            QualitySettings.shadowDistance = 2048;
        } else {
            Debug.Log("ShadowsMod: Shadows are set to Disabled.");
            QualitySettings.shadowDistance = 0;
        }
    }
}