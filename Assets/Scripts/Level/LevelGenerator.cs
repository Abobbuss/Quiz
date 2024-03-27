using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Level[] _levels;
    [SerializeField] private Tilemap _tilemap;

    private int _currentLevelIndex = 0;
    private float _offsetY = 1.5f;
    private float _offsetX = 1.5f;

    private void Start()
    {
        GenerateLevel(_currentLevelIndex);
    }

    private void GenerateLevel(int levelIndex)
    {
        Level levelToGenerate = _levels[levelIndex];

        if (!levelToGenerate.ValidateLevelSettings())
            return;

        int objectCount = levelToGenerate.countObjectsOnLevel;
        LevelObject[] objects = levelToGenerate.objects;
        int rowCount = levelToGenerate.rowCount;
        int columnCount = levelToGenerate.columnCount;

        Vector3 center = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        
    }

    public void NextLevel()
    {
        _currentLevelIndex++;

        if (_currentLevelIndex < _levels.Length)
        {
            GenerateLevel(_currentLevelIndex);
        }
        else
        {
            Debug.Log("All levels completed!");
        }
    }
}
