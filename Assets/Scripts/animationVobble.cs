using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationVobble : MonoBehaviour
{
    Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        anime.GetComponent<Animator>();
    }
    
    public void Vobble()
    {
        anime.SetBool("Vobble", true);
    }

    public void VobbleOff()
    {
        anime.SetBool("Vobble", false);
    }
}
