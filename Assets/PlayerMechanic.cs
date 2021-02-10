using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanic : MonoBehaviour
{
    [SerializeField] private int miniCubesCount_;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Minicube"))
        {
            miniCubesCount_++;
            Destroy(other.gameObject);
        }
    }
}
