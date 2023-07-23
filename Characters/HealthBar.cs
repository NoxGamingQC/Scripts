using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthValue;
    public bool changeBarColorByHealthValue = false;
    public Gradient barColorScheme;
    public Image bar;

    public bool needToFollowCameraView = false;
    public Transform viewCamera;

    public void setMaxHealth(int health)
    {
        healthValue.maxValue = health;
        healthValue.value = health;
        if(changeBarColorByHealthValue) {
            bar.color = barColorScheme.Evaluate(1f);
        }
    }

    public void setHealth(int health) {
        healthValue.value = health;
        if(changeBarColorByHealthValue) {
            bar.color = barColorScheme.Evaluate(healthValue.normalizedValue);
        }
    }

    void LateUpdate() {
        if(needToFollowCameraView) {
            transform.LookAt(transform.position + viewCamera.forward);
        }
    }
}
