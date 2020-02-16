using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDebug : MonoBehaviour
{
    public GameObject hit;

    private void Start()
    {
        hit.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        hit.SetActive(true);

    }
}
