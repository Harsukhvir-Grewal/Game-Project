using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.position = new Vector3(10.1f, 5.5f, 83.9f);
    }
}
