using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDestroy : MonoBehaviour
{
    public GameObject obj;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(obj);
    }
}