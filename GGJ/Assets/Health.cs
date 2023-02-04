using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;
    public void SetMaxHealth(int maxHealth)
    { slider.value = maxHealth; }
}
