using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;

public class PlayerLight : MonoBehaviour
{
    Slider slider;
    [SerializeField] Sprite bigFire;
    [SerializeField] Sprite noFire;

    [SerializeField] float maxInnerRaduis = 2f;
    [SerializeField] float minInnerRaduis = 0.5f;
    [SerializeField] float maxOuterRaduis = 5f;
    [SerializeField] float minOuterRaduis = 2f;
    [SerializeField] float maxIntensity = 4f;
    [SerializeField] float minIntensity = 0.4f;

    [SerializeField] float currentInnerRaduis = 3f;
    [SerializeField] float curretOuterRaduis = 4f;
    [SerializeField] float currentIntensity = 3f;

    [SerializeField] float intensityDecay = 0.1f;
    [SerializeField] float raduisDecay = 0.1f;

    Light2D playerLight;
    GameObject lanternObject;
    Image lantern;


    void Start()
    {
        lanternObject = GameObject.FindGameObjectWithTag("LanternUI");
        lantern = lanternObject.GetComponent<Image>();

        slider = FindObjectOfType<Slider>();
        slider.minValue = minIntensity;
        slider.maxValue = maxIntensity;
        playerLight = GetComponentInChildren<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
        LightDecay();
    }

    void LightDecay()
    {
        slider.value = currentIntensity;
        playerLight.intensity = currentIntensity;
        playerLight.pointLightOuterRadius = curretOuterRaduis;
        playerLight.pointLightInnerRadius = currentInnerRaduis;
        if(currentIntensity > minIntensity)
            currentIntensity -= intensityDecay * Time.deltaTime;
        if (currentInnerRaduis > minInnerRaduis)
            currentInnerRaduis -= raduisDecay * Time.deltaTime;
        if (curretOuterRaduis > minOuterRaduis)
            curretOuterRaduis -= raduisDecay * Time.deltaTime;

    }

    void UpdateUI()
    {
        slider.value = currentIntensity;
        if (currentIntensity < minIntensity + 0.2f)
        {
            lantern.sprite = noFire;
        }
        else if(currentIntensity > minIntensity + 0.2f)
        {
            lantern.sprite = bigFire;
        }
    }

    public void AddLight(float lightValue)
    {
        currentIntensity += lightValue;
        currentInnerRaduis += lightValue;
        curretOuterRaduis += lightValue;
    }
}
