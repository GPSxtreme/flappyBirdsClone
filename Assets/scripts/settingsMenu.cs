using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class settingsMenu : MonoBehaviour
{
    public static settingsMenu instance;
    public AudioMixer masterMixer;
    public Slider musicSlider;
    public Slider sfxSlider;
    public Dropdown qualityDropDown;
    void Awake(){
        instance = this;
    }
    void Start()
    {
        musicSlider.value = PlayerPrefs.GetInt("musicVolume");
        sfxSlider.value = PlayerPrefs.GetInt("sfxVolume");
        qualityDropDown.value = PlayerPrefs.GetInt("qualityIndex");
    }
    void Update()
    {
        
    }
    public void closeSettingsMenu(){
        uiController.instance.settingsMenuToggle();
    }
    public void setQuality (int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt("qualityIndex",qualityIndex);
    }
    public void setMusicVolume(float volume){
        masterMixer.SetFloat("musicVolume",volume);
        PlayerPrefs.SetInt("musicVolume",((int)volume));
    }
    public void setSfxVolume(float volume){
        masterMixer.SetFloat("sfxVolume",volume);
        PlayerPrefs.SetInt("sfxVolume",((int)volume));
    }
}
