using UnityEngine;

[CreateAssetMenu]
public class LivesConfiguration : ScriptableObject
{
    [SerializeField] private int _maximumValue;

    public int MaximumValue => _maximumValue;
}