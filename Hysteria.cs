using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hysteria : MonoBehaviour
{
    public float maxhysteriaCount;
    public GameObject panel;
    public GameObject particle;
    private float hysteriacount = 0;
    public Slider hysteriaSlider;
    public float minspeed;
    private bool _Hysteria = false;
    public bool edu;
    public GameObject texts;
    public string thisLevel;
    public GameObject text2;
    void Start()
    {
        hysteriaSlider.maxValue = maxhysteriaCount;
        hysteriaSlider.value = hysteriacount;
    }
    public void HysteriaUpdate(float count)
    {
        hysteriacount += count;
        hysteriaSlider.value = hysteriacount;
        if(hysteriacount >= maxhysteriaCount)
        {
            panel.SetActive(true);
            particle.SetActive(true);
            Camera.main.gameObject.GetComponent<Animator>().SetBool("Hysteria", true);
            GameObject.FindWithTag("Player").GetComponent<PlayerController>().SpriteShift();
            GameObject.FindWithTag("Player").GetComponent<PlayerController>().speed*=2;
            _Hysteria = true;
        }
        
    }
    void FixedUpdate()
    {
        if (_Hysteria)
        {
            if (edu)
            {
                texts.SetActive(false);
                text2.SetActive(true);
            }
            hysteriaSlider.value = hysteriacount;
            hysteriacount -= Time.deltaTime * minspeed;
            if(hysteriacount <= 0)
            {
                SceneManager.LoadScene(thisLevel);
            }
        }
    }
}
