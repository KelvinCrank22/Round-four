using System;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField] PathTile _start = null;
    PathTile _next;
    public float moveSpeed = 2f;
    void Start()
    {
        _next = _start;
    }

    void Update()
    {
        Move();
    }
    void Move()
    {
        if (_next)
        {
            if (transform.position == _next.transform.position)
                _next = _next.next;
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, _next.transform.position,
                moveSpeed * Time.deltaTime);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
