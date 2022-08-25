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

    [SerializeField]
    private AudioSource Boing;
   
    void Start()
    {
        button = GetComponent<Button>();
        button.image.overrideSprite = grayScale;
    }
    
    public void changeSprite()
    {
        button.image.overrideSprite = color;
        button.enabled = false;
        Boing.Play();
        Invoke(nameof(EnableButton), 1);
    }

    public void shake()
    {
        const float duration = 0.6f;
        const float strength = 0.2f;

        shaker.DOShakePosition(duration, strength);
        shaker.DOShakeRotation(duration, strength);
        shaker.DOShakeScale(duration, strength);
    }

    private void EnableButton()
    {
        button.enabled = true;
    }
}
