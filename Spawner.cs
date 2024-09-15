using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Spawner : MonoBehaviour
{
    [SerializeField] private Bullet _prefab;
    [SerializeField] private Transform _target;
    [SerializeField] private float _deleay;
    [SerializeField] private float _speed;

    private Transform _target;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds wait = new WaitForSeconds(_deleay)

        while (enabled)
        {
            var direction = (_target.position - transform.position).normalized;
            Bullet bullet = Instantiate(_prefab, transform.position + direction, Quaternion.identity);

            bullet.Init(direction, _speed, _target)

            yield return wait;
        }
    }
}