using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _stepSize;
    [SerializeField] private float _minHeight;
    [SerializeField] private float _maxHeight;

    private Vector3 _targetPositiion;

    private void Start()
    {
        _targetPositiion = transform.position;
    }

    private void Update()
    {
        if (transform.position != _targetPositiion)
            transform.position = Vector3.MoveTowards(transform.position, _targetPositiion, _speed * Time.deltaTime);
    }

    public void TryMoveUp()
    {
        if (_targetPositiion.y < _maxHeight)
            MovementPosition(_stepSize);
    }

    public void TryMoveDown()
    {
        if (_targetPositiion.y > _minHeight)
            MovementPosition(-_stepSize);
    }
    
    private void MovementPosition(float stepSize)
    {
        _targetPositiion = new Vector2(_targetPositiion.x, _targetPositiion.y + stepSize);
    }
}
