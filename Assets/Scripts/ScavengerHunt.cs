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
    public AudioClip sound;

        void Update()
    {
        numFish.text = "You have found " + fishCount + " of the 8 fish";

        if (fishCount == 0)
        {
            fish.text = "Find the golden cleaner wrasse";
        }
        if (fishCount == 1)
        {
            fish.text = "Find the trumpet fish";
        }
        if (fishCount == 2)
        {
            fish.text = "Find the humu";
        }
        if (fishCount == 3)
        {
            fish.text = "Find the durgon trigger";
        }
        if (fishCount == 4)
        {
            fish.text = "Find the moorish idol";
        }
        if (fishCount == 5)
        {
            fish.text = "Find the clownfish";
        }
        if (fishCount == 6)
        {
            fish.text = "Find the orange roughy";
        }
        if (fishCount == 7)
        {
            fish.text = "Find the nassau grouper";
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == fish.text && !success.isPlaying)
        {
            fishCount++;
            success.PlayOneShot(sound);
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
