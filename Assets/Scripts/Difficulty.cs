 using UnityEngine;

public class Difficulty : MonoBehaviour
{
    static float secondsToMaxDifficulty = 60f;

    public static void ResetDifficulty()
    {
      
    }

    public static float getDifficultyPercentage()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
    }
}