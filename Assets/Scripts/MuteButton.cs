using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    
    public GameObject soundOn;
    public GameObject soundOff;

    private void Start()
    {
        soundOn.SetActive(true);
        soundOff.SetActive(false);
    }
    public void MuteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
            soundOn.SetActive(false);
            soundOff.SetActive(true);
        }
        else
        {
            AudioListener.volume = 1;
            soundOn.SetActive(true);
            soundOff.SetActive(false);
        }
    }
}
