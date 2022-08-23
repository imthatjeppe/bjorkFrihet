using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SpriteChange : MonoBehaviour
{
    Button button;
    public Sprite grayScale;
    public Sprite color;

    [SerializeField]
    private Transform shaker;
    private bool pressed;

    void Start()
    {
        pressed = false;
        button = GetComponent<Button>();
        button.image.overrideSprite = grayScale;
    }

    void Update()
    {

    }
    public void changeSprite()
    {
        button.image.overrideSprite = color;
    }

    public void shake()
    {
        const float duration = 0.8f;
        const float strength = 0.4f;

        shaker.DOShakePosition(duration, strength);
        shaker.DOShakeRotation(duration, strength);
        shaker.DOShakeScale(duration, strength);

    }
    
}
