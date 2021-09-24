using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Beweegt langs een path
public class PathFollower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalTreshold;
    private Path _path;
    private Waypoint _currentWaypoint;

    private void Start()
    {
        SetupPath();
    }

    private void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetPathStart();
        transform.LookAt(new Vector3(_currentWaypoint.GetPosition().x, transform.position.y, _currentWaypoint.GetPosition().z));
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, new Vector3(_currentWaypoint.GetPosition().x, transform.position.y, _currentWaypoint.GetPosition().z)) < _arrivalTreshold)
        {
            if (_currentWaypoint == _path.GetPathEnd()) PathComplete();
            else
            {
                _currentWaypoint = _path.GetNextWaypoint(_currentWaypoint);
                transform.LookAt(new Vector3(_currentWaypoint.GetPosition().x, transform.position.y, _currentWaypoint.GetPosition().z));
            }
        }
    }

    private void PathComplete()
    {
        Debug.Log("Einde path");
        _speed = 0;
    }
}
