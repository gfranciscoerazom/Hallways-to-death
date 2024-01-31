using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] private Slider musicSlider;

    private void Update()
    {
        AudioManager.Instance.MusicVolume(musicSlider.value);
    }

}
