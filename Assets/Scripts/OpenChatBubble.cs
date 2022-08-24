using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class OpenChatBubble : MonoBehaviour
{
    public GameObject chatBubble;
    void Start()
    {
        chatBubble.SetActive(false);
    }

    public void showChatBubble()
    {
        chatBubble.SetActive(true);
    }

    public void hideChatBubble()
    {
        chatBubble.SetActive(false);
    }
}
