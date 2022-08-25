using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public GameObject LeftSide, RightSide, Main, addedMain;
    public float score;
    [SerializeField]
    private AudioSource buttons;
    void Start()
    {
        LeftSide.SetActive(false);
        RightSide.SetActive(false);
        addedMain.SetActive(false);
        Main.SetActive(true);
    }

    private void Update()
    {
        if(score >= 7)
        {
            addedMain.SetActive(true);
        }
    }
    public void activateMain()
    {
        LeftSide.SetActive(false);
        RightSide.SetActive(false);
        Main.SetActive(true);
        buttons.Play();
    }
    public void activeLeftSide()
    {
        LeftSide.SetActive(true);
        RightSide.SetActive(false);
        Main.SetActive(false);
        buttons.Play();
    }
    public void activeRightSide()
    {
        LeftSide.SetActive(false);
        RightSide.SetActive(true);
        Main.SetActive(false);
        buttons.Play();
    }

    public void RemoveEnding()
    {
        score = 6;
        addedMain.SetActive(false);
    }
}
