using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class SpawnMiniCubes : MonoBehaviour
{
    //Variables
    [SerializeField] private GameObject miniCube_;
    private float power_ = 7f;
    private float radius_ = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(miniCube_, other.transform.position + Vector3.right, Quaternion.identity);
                miniCube_.GetComponent<Rigidbody>().AddExplosionForce(power_, transform.position, radius_, 1f);
            }
            Destroy(gameObject);
        }
    }
}
