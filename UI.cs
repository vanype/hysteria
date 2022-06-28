using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Camera camer;

    public RectTransform health;
    public int width;
    public int height;

    private bool SetSpawn;

    private void Start()
    {
        width = camer.pixelWidth / 2;
        height = camer.pixelHeight / 2;       
        //меняет положение ползунка количества жизней и перезарядки 
        health.anchoredPosition = new Vector2(width/2/2/2 , height/2+70);
        
    }
    
}
