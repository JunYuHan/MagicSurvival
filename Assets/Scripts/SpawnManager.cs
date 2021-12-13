using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float RangeMax = 5.0f;
    float RangeMin = -5.0f;
    float Random = -5.0f;
    BoxCollider2D RangeCollider;
    void Awake()
    {
        RangeCollider = RangeCollider.GetComponent<BoxCollider2D>();
    }
    public GameObject enemy;
    private void Start()
    {
        for (int i = 0; i < 1000; i++)
            Instantiate(enemy, GetRandomPosition(), Quaternion.identity);
    }
    public Vector3 GetRandomPosition()
    {
        float radius = 3f;
        Vector3 playerPosition = transform.position;

        float a = playerPosition.x;
        float b = playerPosition.y;

        float x = Random.Range(-radius + a, radius + a);
        float y_b = Mathf.Sqrt(Mathf.Pow(radius, 2) - Mathf.Pow(x - a, 2));
        y_b *= Random.(0, 2) == 0 ? -1 : 1;
        float y = y_b + b;

        Vector3 randomPosition = new Vector3(x, y, 0);

        return randomPosition;
    }


