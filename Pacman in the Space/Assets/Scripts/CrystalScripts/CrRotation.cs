using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrRotation : MonoBehaviour
{
    int degree = 0;
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, degree, transform.rotation.eulerAngles.z);
        if (degree < 180)
            degree += 2;
        else
            degree = 0;
    }
}
