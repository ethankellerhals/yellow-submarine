using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScavengerHunt : MonoBehaviour
{

    [SerializeField] public int speed;

    public GameObject wrasse;
    public GameObject trumpet;
    public GameObject humu;
    public GameObject durgonTrigger;

    public GameObject moorishIdol;
    public GameObject clownFish;
    public GameObject orangeRoughy;
    public GameObject nassauGrouper;

    private int fishCount = 1;

    public TextMeshProUGUI fish;
    public TextMeshProUGUI numFish;

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


        // check if player/camera collides with or is close to the fish you're looking for
      
        // float distance = Vector3.Distance(player.transform.position, the fish you're looking for.transform.position);
        // if (distance < 5)
        // {
        //      fishCount++
        // }  

        
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
