using UnityEngine;

[CreateAssetMenu]
public class BallsSpawnerConfiguration : ScriptableObject
{
    [SerializeField] private BallConfiguration _ballConfiguration;
    [SerializeField] private float _secondsBetweenSpawned;
    [SerializeField] private Ball _template;

    public BallConfiguration BallConfiguration => _ballConfiguration;
    public float SecondsBetweenSpawned => _secondsBetweenSpawned;
    public Ball Template => _template;
}