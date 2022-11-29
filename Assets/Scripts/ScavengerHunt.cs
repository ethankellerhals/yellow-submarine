using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScavengerHunt : MonoBehaviour
{

    [SerializeField] public int speed;
    
    [SerializeField] Transform distanceToFish; // distance from the current fish

    private float distanceValue; //distance value


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
    public TextMeshProUGUI distanceText; //sent to UI; displays distance value
    
    void Update()
    {
    
        numFish.text = "You have found " + fishCount + " of the 8 fish";

        float wrasse_dist = Vector3.Distance(transform.position, wrasse.transform.position);
        float trumpet_dist = Vector3.Distance(transform.position, trumpet.transform.position);
        float humu_dist = Vector3.Distance(transform.position, humu.transform.position);
        float durgonTrigger_dist = Vector3.Distance(transform.position, durgonTrigger.transform.position);

        float moorishIdol_dist = Vector3.Distance(transform.position, moorishIdol.transform.position);
        float clownFish_dist = Vector3.Distance(transform.position, clownFish.transform.position);
        float orangeRoughy_dist = Vector3.Distance(transform.position, orangeRoughy.transform.position);
        float nassauGrouper_dist = Vector3.Distance(transform.position, nassauGrouper.transform.position);
        
        //distanceToFish is the reference for the current fish. rename if needed
        //distanceValue = (distanceToFish.transform.position - transform.position).magnitude;
        //distanceText.text = "Distance: " + distanceValue.ToString("F1") + " meters";


        if (fishCount == 0)
        {
            fish.text = "Wrasse";
            distanceValue = (wrasse.transform.position - transform.position).magnitude;
            distanceText.text = "Distance: " + distanceValue.ToString("F1") + " meters";
        }
        if (fishCount == 1)
        {
            fish.text = "Trumpet";
            distanceValue = (trumpet.transform.position - transform.position).magnitude;
            distanceText.text = "Distance: " + distanceValue.ToString("F1") + " meters";
        }
        if (fishCount == 2)
        {
            fish.text = "Humu";
            distanceValue = (humu.transform.position - transform.position).magnitude;
            distanceText.text = "Distance: " + distanceValue.ToString("F1") + " meters";            
        }
        if (fishCount == 3)
        {
            fish.text = "Durgon Trigger";
            distanceValue = (durgonTrigger.transform.position - transform.position).magnitude;
            distanceText.text = "Distance: " + distanceValue.ToString("F1") + " meters";            
        }
        if (fishCount == 4)
        {
            fish.text = "Moorish Idol";
            distanceValue = (moorishIdol.transform.position - transform.position).magnitude;
            distanceText.text = "Distance: " + distanceValue.ToString("F1") + " meters";            
        }
        if (fishCount == 5)
        {
            fish.text = "Clownfish";
            distanceValue = (clownFish.transform.position - transform.position).magnitude;
            distanceText.text = "Distance: " + distanceValue.ToString("F1") + " meters";            
        }
        if (fishCount == 6)
        {
            fish.text = "Orange Roughy";
            distanceValue = (orangeRoughy.transform.position - transform.position).magnitude;
            distanceText.text = "Distance: " + distanceValue.ToString("F1") + " meters";            
        }
        if (fishCount == 7)
        {
            fish.text = "Nassau Grouper";
            distanceValue = (nassauGrouper.transform.position - transform.position).magnitude;
            distanceText.text = "Distance: " + distanceValue.ToString("F1") + " meters";            
        }
        
    }

    // OR if the player has a rigidbody/mesh collider  

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == fish.text)
        {
            fishCount++;
        }
    }
}
