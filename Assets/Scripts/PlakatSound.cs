using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlakatSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource plakat;

    public void playPlakatSound()
    {
        plakat.Play();
    }
}
