/***
 * Author: Cristian Misla
 * Create: 10/18/22
 * Modified: 11/1/22
 * Description: Controls when the timeline plays
 ***/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineControler : MonoBehaviour
{
    PlayableDirector playDir;

    // Start is called before the first frame update
    void Start()
    {
        playDir = GetComponent<PlayableDirector>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playDir.Play(); 
        }
    }


}
