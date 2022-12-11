using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBounds : MonoBehaviour
{
    public TextMeshProUGUI turnAround;

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("terrain"))
        {
            turnAround.text = "TURN BACK";
            StartCoroutine(Timer());
        }

        transform.Rotate(0, 180, 0);
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5f);
        turnAround.text = "";
    }
}
