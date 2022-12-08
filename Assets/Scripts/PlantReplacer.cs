using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantReplacer : MonoBehaviour
{



    public GameObject AltPlant;
    private GameObject InstancePlant;

    // Start is called before the first frame update
    void Start()
    {

        InstancePlant = Instantiate(AltPlant, transform.position, transform.rotation) as GameObject;
        //InstancePlant.transform.localScale = 1f * transform.GetChild(0).localScale;
        InstancePlant.transform.parent = transform.parent;
        this.gameObject.SetActive(false);


        //foreach( Transform child in RockPlantParent.transform)
        //{
        //    GameObject tempRockAlt = Instantiate(RockAlt, child) as GameObject;
        //    tempRockAlt.transform.parent = RockPlantParent.transform;
        //    child.gameObject.SetActive(false);          
        //}

        //foreach (Transform child in TubePlantParent.transform)
        //{
        //    GameObject tempTubeAlt = Instantiate(TubeAlt, child) as GameObject;
        //    tempTubeAlt.transform.parent = TubePlantParent.transform;
        //    child.gameObject.SetActive(false);
        //}

        //foreach (Transform child in FlatPlantParent.transform)
        //{
        //    GameObject tempFlatAlt = Instantiate(FlatAlt, child) as GameObject;
        //    tempFlatAlt.transform.parent = FlatPlantParent.transform;
        //    child.gameObject.SetActive(false);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
