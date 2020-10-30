using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PlayerLight : MonoBehaviour
{
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


    void Start()
    {
        playerLight = GetComponentInChildren<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        LightDecay();
    }

    void LightDecay()
    {
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
}
