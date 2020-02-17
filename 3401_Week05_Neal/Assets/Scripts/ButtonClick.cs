using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public AudioSource buttonAudioSource1;

    public void OnButtonClicked()
    {
        if (buttonAudioSource1.isPlaying)
        {
            buttonAudioSource1.Stop();
        }
        else
        {
            buttonAudioSource1.Play();
        }
    }



}
