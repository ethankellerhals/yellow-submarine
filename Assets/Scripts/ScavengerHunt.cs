using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScavengerHunt : MonoBehaviour
{

    public GameObject wrasse;
    public GameObject trumpet;
    public GameObject humu;
    public GameObject durgonTrigger;

    public GameObject moorishIdol;
    public GameObject clownFish;
    public GameObject orangeRoughy;
    public GameObject nassauGrouper;

    private int fishCount = 0;

    public TextMeshProUGUI fish;
    public TextMeshProUGUI numFish;

    public AudioSource success;

    void Update()
    {
        numFish.text = "You have found " + fishCount + " of the 8 fish";

        if (fishCount == 0)
        {
            fish.text = "Wrasse";
        }
        if (fishCount == 1)
        {
            fish.text = "Trumpet";
        }
        if (fishCount == 2)
        {
            fish.text = "Humu";
        }
        if (fishCount == 3)
        {
            fish.text = "Durgon Trigger";
        }
        if (fishCount == 4)
        {
            fish.text = "Moorish Idol";
        }
        if (fishCount == 5)
        {
            fish.text = "Clownfish";
        }
        if (fishCount == 6)
        {
            fish.text = "Orange Roughy";
        }
        if (fishCount == 7)
        {
            fish.text = "Nassau Grouper";
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == fish.text)
        {
            fishCount++;
            success.Play();
        }
        //else if (trumpet == collision.gameObject.name)
        //{
        //    fishCount++;
        //}
        //else if (humu == collision.gameObject.name)
        //{
        //    fishCount++;
        //}
        //else if (durgonTrigger == collision.gameObject)
        //{
        //    fishCount++;
        //}
        //else if (durgonTrigger == collision.gameObject)
        //{
        //    fishCount++;
        //}
        //else if (moorishIdol == collision.gameObject)
        //{
        //    fishCount++;
        //}
        //else if (clownFish == collision.gameObject)
        //{
        //    fishCount++;
        //}
        //else if (orangeRoughy == collision.gameObject)
        //{
        //    fishCount++;
        //}
        //else if (nassauGrouper == collision.gameObject)
        //{
        //    fishCount++;
        //}
    }
}

