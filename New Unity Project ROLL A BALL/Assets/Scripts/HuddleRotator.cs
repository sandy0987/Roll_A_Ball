using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuddleRotator : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(90, 90, 90) * Time.deltaTime);
    }
}

