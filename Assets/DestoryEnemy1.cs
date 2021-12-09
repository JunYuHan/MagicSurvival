using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryEnemy1 : MonoBehaviour
{
    public float DestroyTime = 2.0f;
    void Start()
    {
		Destroy(gameObject, DestroyTime);
    }
    // Update is called once per frame
    void Update()
    {
    }
}
