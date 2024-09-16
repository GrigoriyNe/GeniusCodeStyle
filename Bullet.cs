using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Bullet : MonoBehaviour
{
    private Vector3 _direction;
    private Rigidbody _rigidbody;
    private float _speed;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    public void Init(Vector3 direction, float speed)
    {
        _direction = direction;
        _speed = speed;
    }

    private void Move()
    {
        _rigidbody.velocity = _direction * _speed * Time.deltaTime;
    }
}
