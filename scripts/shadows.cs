// #name Graphics.Shadows
// #author NathanLithia
// #desc Sets Graphics options.

using UnityEngine;

public static class ShadowsMod {
    public static void Main() {
        // Set if shadows are on or off
        bool ShadowsEnabled = true;
        // Set the max shadow distance (falls off at about 1024 max)
        int MaxShadowDistance = 1024;

        if (ShadowsEnabled == true) {
            QualitySettings.shadowDistance = MaxShadowDistance;
        } else {
            Debug.Log("ShadowsMod: Shadows are set to Disabled.");
            QualitySettings.shadowDistance = 0;
        }
    }
}