using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swim : MonoBehaviour
{
    public int movementSpeed = 2;
    public int dir = 1;

    void Start()
    {
        StartCoroutine(Rotate());
    }
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * movementSpeed * dir;
    }

    IEnumerator Rotate()
    {
        while(true)
        {
            float rand = Random.Range(0f, 180f);
            transform.Rotate(0, rand, 0, Space.Self);

            yield return new WaitForSeconds(5f);
        }
    }
}
