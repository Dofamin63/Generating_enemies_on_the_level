using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Transform _target;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position, _moveSpeed * Time.deltaTime);
        transform.LookAt(_target);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
