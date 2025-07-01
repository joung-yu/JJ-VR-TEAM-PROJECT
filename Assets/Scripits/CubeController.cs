using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public GameObject cubePrefab;
    public float speed = 3.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cubePrefab.transform.position = Time.deltaTime * transform.forward * speed;
        }
    }
}
