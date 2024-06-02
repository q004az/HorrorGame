using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuScript : MonoBehaviour
{
    public bool isOpened = false; //Открыто ли меню
    public float volume = 0; //Громкость
    public float brightness = 0; //Яркость
    public int quality = 0; //Качество
    public bool isFullscreen = false; //Полноэкранный режим
    public AudioMixer audioMixer; //Регулятор громкости
    public Dropdown resolutionDropdown; //Список с разрешениями для игры

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeVolume(float val) //Изменение звука
    {
        volume = val;
    }

    public void ChangeLightning(float val) //Изменение звука
    {
        brightness = val;
    }

    public void SaveSettings()
    {
        audioMixer.SetFloat("MasterVolume", volume); //Изменение уровня громкости
    }

    public void Quit()
    {
        Application.Quit();
    }
}
