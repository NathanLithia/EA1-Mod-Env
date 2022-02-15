using UnityEngine;

public static class FPSCap {
    public static void Main() {
        int FramerateCap = 120;
        Application.targetFrameRate = FramerateCap;
    }
}