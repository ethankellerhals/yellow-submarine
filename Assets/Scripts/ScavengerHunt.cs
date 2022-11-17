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
        // if (distance < some number)
        // {
        //      fishCount++
        // }  
        
    }


    // OR if the player has a rigidbody/mesh collider  

    // void OnCollisionEnter(Collision collision)
    // {
    //     if(collision.gameObject.tag == fish.text)
    //     {
    //         fishCount++;
    //     }
    // }
}
