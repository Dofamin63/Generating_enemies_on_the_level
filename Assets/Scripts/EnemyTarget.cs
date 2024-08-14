using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Transform[] _wayPoints;
    private int _currentWayPoint;

    private void Start()
    {
        transform.LookAt(_wayPoints[_currentWayPoint]);
    }

    private void Update()
    {
        if (transform.position == _wayPoints[_currentWayPoint].position)
        {
            _currentWayPoint = (_currentWayPoint + 1) % _wayPoints.Length;
            transform.LookAt(_wayPoints[_currentWayPoint]);
        }

        transform.position = Vector3.MoveTowards(transform.position, _wayPoints[_currentWayPoint].position,
            _speed * Time.deltaTime);
    }
}