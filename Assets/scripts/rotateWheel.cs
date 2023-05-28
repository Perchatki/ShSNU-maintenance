using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateWheel : MonoBehaviour
{
    public float rpm;
    void Update()
    {
        transform.eulerAngles += new Vector3(0, 0, -180 * Time.deltaTime * rpm / 60);
    }
}
