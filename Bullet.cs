using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Bullet : MonoBehaviour
{
    private Vector3 _direction;
    private Rigidbody _rigidbody;
    private Transform _target;
    private float _speed:

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    public void Init(Vector3 direction, float speed, Transform target)
    {
        _direction = direction;
        _speed = speed;
        _target = target;
    }

    private void Move()
    {
        _rigidbody.velocity = _direction * _speed * Time.deltaTime;
    }
}