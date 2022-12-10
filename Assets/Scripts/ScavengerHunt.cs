using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.XR;
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
    private float distanceValue;

    public TextMeshProUGUI fish;
    public TextMeshProUGUI numFish;
    public TextMeshProUGUI distance;


    public AudioSource success;
    public AudioClip sound;



    void Update()
    {

        float wrasse_dist;
        float trumpet_dist;
        float humu_dist;
        float durgonTrigger_dist;
        float moorishIdol_dist;
        float clownFish_dist;
        float orangeRoughy_dist;
        float nassauGrouper_dist;

        numFish.text = "You have found " + fishCount + " of the 8 fish";

        if (fishCount == 0)
        {
            fish.text = "Wrasse";

            // Distance
            wrasse_dist = Vector3.Distance(transform.position, wrasse.transform.position);
            distanceValue = (wrasse.transform.position - transform.position).magnitude;
            distance.text = "Distance: " + distanceValue.ToString("F1") + " meters";
        }
        if (fishCount == 1)
        {
            fish.text = "Trumpet";

            // Distance
            trumpet_dist = Vector3.Distance(transform.position, trumpet.transform.position);
            distanceValue = (trumpet.transform.position - transform.position).magnitude;
            distance.text = "Distance: " + distanceValue.ToString("F1") + " meters";
        }
        if (fishCount == 2)
        {
            fish.text = "Humu";

            // Distance
            humu_dist = Vector3.Distance(transform.position, humu.transform.position);
            distanceValue = (humu.transform.position - transform.position).magnitude;
            distance.text = "Distance: " + distanceValue.ToString("F1") + " meters";
        }
        if (fishCount == 3)
        {
            fish.text = "Durgon Trigger";

            // Distance
            durgonTrigger_dist = Vector3.Distance(transform.position, durgonTrigger.transform.position);
            distanceValue = (durgonTrigger.transform.position - transform.position).magnitude;
            distance.text = "Distance: " + distanceValue.ToString("F1") + " meters";
        }
        if (fishCount == 4)
        {
            fish.text = "Moorish Idol";

            // Distance
            moorishIdol_dist = Vector3.Distance(transform.position, moorishIdol.transform.position);
            distanceValue = (durgonTrigger.transform.position - transform.position).magnitude;
            distance.text = "Distance: " + distanceValue.ToString("F1") + " meters";
        }
        if (fishCount == 5)
        {
            fish.text = "Clownfish";

            // Distance
            clownFish_dist = Vector3.Distance(transform.position, clownFish.transform.position);
            distanceValue = (clownFish.transform.position - transform.position).magnitude;
            distance.text = "Distance: " + distanceValue.ToString("F1") + " meters";
        }
        if (fishCount == 6)
        {
            fish.text = "Orange Roughy";

            // Distance
            orangeRoughy_dist = Vector3.Distance(transform.position, orangeRoughy.transform.position);
            distanceValue = (orangeRoughy.transform.position - transform.position).magnitude;
            distance.text = "Distance: " + distanceValue.ToString("F1") + " meters";
        }
        if (fishCount == 7)
        {
            fish.text = "Nassau Grouper";

            // Distance
            nassauGrouper_dist = Vector3.Distance(transform.position, nassauGrouper.transform.position);
            distanceValue = (nassauGrouper.transform.position - transform.position).magnitude;
            distance.text = "Distance: " + distanceValue.ToString("F1") + " meters";
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == fish.text && !success.isPlaying)
        {
            fishCount++;
            success.PlayOneShot(sound);
        }
    }
}

