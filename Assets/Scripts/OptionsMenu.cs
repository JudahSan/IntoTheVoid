using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OptionsMenu : MonoBehaviour
{
    public Slider sensitivitySlider;
    public Toggle isMuteToggle;
    public void UpdateSensitivity()
    {
        float value = sensitivitySlider.value;
        PlayerPrefs.SetFloat("Sensitivity", value);
    }

    public void UpdateMute()
    {
        bool value = isMuteToggle.isOn;
        if(value)
        {
            AudioListener.volume = 0;

        }
        else
        {
            AudioListener.volume = 1;
        }
        PlayerPrefs.SetInt("IsMute", value ? 1 : 0);
    }
}
