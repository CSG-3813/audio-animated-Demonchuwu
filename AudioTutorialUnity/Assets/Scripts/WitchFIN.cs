/***
 * Author: Stu Dent
 * Create: 10/18/22
 * Modified:
 * Description: triggers the witch animation and sound cackle
 ***/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchFIN : MonoBehaviour
{
    public string animtionParamater;
    Animator anim;
    AudioSource audioSource;
    AudioClip audioClip;



    private void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        Debug.Log(audioSource);
        audioClip = audioSource.clip;
        Debug.Log(audioClip);
    }

private void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
        {
            anim.SetBool(animtionParamater, true);
        }
    }

private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool(animtionParamater, false);
        }
    }



    public void playCackle()
    {
        audioSource.PlayOneShot(audioClip);
    }


}
