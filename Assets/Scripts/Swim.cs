using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
 
public class Swim : MonoBehaviour
{
    public int movementSpeed = 2;
    public int dir = 1;

    private bool check = false;

  

 
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);
        foreach (var item in devices) {
            Debug.Log(item.name + item.characteristics);
        }

        float rand = Random.Range(4f, 7f);
        StartCoroutine(Rotate(rand));
    }
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * movementSpeed * dir;
    }
 
    IEnumerator Rotate(float time)
    {
        
        while(true)
        {
            int rand = Random.Range(0, 20);

            for (int i = rand-1; i >= 0; i--)
            {
                transform.Rotate(0, rand-i, 0, Space.Self);
                yield return new WaitForSeconds(.03f);
            }

            yield return new WaitForSeconds(time);
        }
        
    }

    IEnumerator TurnAround()
    {
        check = true;
        for (int i = 20-1; i >= 0; i--)
        {
            transform.Rotate(0, 20-i, 0, Space.Self);
            yield return new WaitForSeconds(.03f);
        }
        //transform.position += transform.forward * 5;
        check = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("terrain") && !check)
        {
            StartCoroutine(TurnAround());
        }
    }
}
