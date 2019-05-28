using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotateZ;
    void Update()
    {
        transform.Rotate(new Vector3(0f,0f,rotateZ*Time.deltaTime));

    }
}
