using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public GameObject LeftSide, RightSide, Main;
    void Start()
    {
        LeftSide.SetActive(false);
        RightSide.SetActive(false);
        Main.SetActive(true);
    }
    public void activateMain()
    {
        LeftSide.SetActive(false);
        RightSide.SetActive(false);
        Main.SetActive(true);
    }
    public void activeLeftSide()
    {
        LeftSide.SetActive(true);
        RightSide.SetActive(false);
        Main.SetActive(false);
    }
    public void activeRightSide()
    {
        LeftSide.SetActive(false);
        RightSide.SetActive(true);
        Main.SetActive(false);
    }
}
