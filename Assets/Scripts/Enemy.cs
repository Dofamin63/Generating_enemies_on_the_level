using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Vector3 _direction;

    private void Update()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * _direction);
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }
}
