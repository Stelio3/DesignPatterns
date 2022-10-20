﻿using System;
using UnityEngine;

public class RotateOnPoint : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;

    private void Awake()
    {
        transform.LookAt(_target);
    }

    private void Update()
    {
        transform.RotateAround(_target.position, Vector3.up, _speed * Time.deltaTime);
    }
}