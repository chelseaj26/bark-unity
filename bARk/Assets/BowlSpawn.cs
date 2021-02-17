using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlSpawn : MonoBehaviour
{
     public GameObject bowl;
     public void Update() {
        bowl.setActive(false); //deactivates bowl on load 
     }
    
    public void AddBowl (GameObject bowl) {
         bowl.setActive(true); //activates bowl on click
       }
    }

