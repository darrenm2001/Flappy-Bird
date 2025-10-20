using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FlyBehaviou : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
}
