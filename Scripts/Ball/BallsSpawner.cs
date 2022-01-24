using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsSpawner : MonoBehaviour
{
    [SerializeField] private Transform _container;

    private BallsSpawnerConfiguration _configuration;
    private IEnumerable<IBallHandler> _ballHandlers;
    private bool _isActive;

    public void Initialize(BallsSpawnerConfiguration configuration, IEnumerable<IBallHandler> ballHandlers)
    {
        _configuration = configuration;
        _ballHandlers = ballHandlers;
        _isActive = true;
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        var delay = new WaitForSeconds(_configuration.SecondsBetweenSpawned);

        while (_isActive)
        {
            var ball = Instantiate(_configuration.Template, _container);
            ball.Initialize(_configuration.BallConfiguration, _ballHandlers);
            yield return delay;
        }
    }
}