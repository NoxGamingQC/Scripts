using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Slider healthValue;
    public bool changeBarColorByHealthValue = false;
    public bool hasTextOnHealthBar = false;
    public bool usePercentText = false;
    public Gradient barColorScheme;
    public Image bar;
    public Text text;
    public bool needToFollowCameraView = false;
    public Transform viewCamera;

    public void setMaxHealth(int health)
    {
        healthValue.maxValue = health;
        healthValue.value = health;
        if(hasTextOnHealthBar) {
            if(usePercentText) {
                text.text = ((health * healthValue.maxValue) / 100) + "%";
            } else {
                text.text = "" + health;
            }
        }
        if(changeBarColorByHealthValue) {
            bar.color = barColorScheme.Evaluate(1f);
        }
    }

    public void setHealth(int health) {
        healthValue.value = health;
        if(hasTextOnHealthBar) {
            if(usePercentText) {
                text.text = ((health * healthValue.maxValue) / 100) + "%";
            } else {
                text.text = "" + health;
            }
        }
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
