using UnityEngine;

[CreateAssetMenu(fileName = "New Level", menuName = "Level")]
public class Level : ScriptableObject
{
    public LevelObject[] objects;
    public int countObjectsOnLevel;
    public int rowCount;
    public int columnCount;

    public bool ValidateLevelSettings()
    {
        int totalObjects = rowCount * columnCount;

        return totalObjects <= countObjectsOnLevel;
    }
}