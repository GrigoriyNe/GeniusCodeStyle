using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Transform _waypoint;
    private Transform[] _waypoints;
    private int _currentWaypoint;
    private float _speed;

    private void Start()
    {
        _waypoints = new Transform[_waypoint.childCount];

        for (int i = 0; i < _waypoint.childCount; i++)
            _waypoints[i] = _waypoint.GetChild(i).GetComponent<Transform>();
    }

    private void Update()
    {
        Move();
        transform.LookAt(_waypoints[_currentWaypoint].position);
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position, _speed * Time.deltaTime);

        if (transform.position == _waypoints[_currentWaypoint].position)
            GetNextPoint();
    }

    private void GetNextPoint()
    {
        _currentWaypoint++;

        if (_currentWaypoint == _waypoints.Length)
            _currentWaypoint = 0;
    }
}
