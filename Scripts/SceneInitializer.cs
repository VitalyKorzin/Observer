using System.Collections.Generic;
using UnityEngine;

public class SceneInitializer : MonoBehaviour
{
    [SerializeField] private BallsSpawner _ballsSpawner;
    [SerializeField] private LivesCounter _livesCounter;
    [SerializeField] private ScoreCounter _scoreCounter;

    public void Initialize(SceneConfiguration configuration)
    {
        _livesCounter.Initialize(configuration.LivesConfiguration);
        _scoreCounter.Initialize();

        var ballHandlers = new List<IBallHandler>
        {
            _scoreCounter,
            _livesCounter
        };

        _ballsSpawner.Initialize(configuration.SpawnerConfiguration, ballHandlers);
    }
}