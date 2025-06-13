using UnityEngine;

public class PlayerPrefAdapter
{
    public static GameManager.eLevelMode PrevLevelMode
    {
        get
        {
            int playModeValue = PlayerPrefs.GetInt(PlayerPrefString.PlayModeKey, (int)GameManager.eLevelMode.MOVES); // Default to MOVES
            return (GameManager.eLevelMode)playModeValue;
        }
        set
        {
            PlayerPrefs.SetInt(PlayerPrefString.PlayModeKey, (int)value);
            PlayerPrefs.Save();
        }
    }
}

public class PlayerPrefString
{
    public const string PlayModeKey = "PreviousPlayMode";

}