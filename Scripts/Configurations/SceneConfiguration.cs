using UnityEngine;

[CreateAssetMenu]
public class SceneConfiguration : ScriptableObject
{
    [SerializeField] private BallsSpawnerConfiguration _spawnerConfiguration;
    [SerializeField] private LivesConfiguration _livesConfiguration;
    public BallsSpawnerConfiguration SpawnerConfiguration => _spawnerConfiguration;
    public LivesConfiguration LivesConfiguration => _livesConfiguration;
}