using UnityEngine;

public class MovingForward : MonoBehaviour
{
    [SerializeField] private float _speed = 3.2f;
    [SerializeField] private float _acceleration = 0.0f;
    private int _calculationsPerSecond = 50;

    void FixedUpdate()
    {
        this.transform.Translate(Vector3.forward * _speed / _calculationsPerSecond, Space.Self);
        _speed += _acceleration;
    }
}
