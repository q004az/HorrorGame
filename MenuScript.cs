using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuScript : MonoBehaviour
{
    public bool isOpened = false; //������� �� ����
    public float volume = 0; //���������
    public float brightness = 0; //�������
    public int quality = 0; //��������
    public bool isFullscreen = false; //������������� �����
    public AudioMixer audioMixer; //��������� ���������
    public Dropdown resolutionDropdown; //������ � ������������ ��� ����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeVolume(float val) //��������� �����
    {
        volume = val;
    }

    public void ChangeLightning(float val) //��������� �����
    {
        brightness = val;
    }

    public void SaveSettings()
    {
        audioMixer.SetFloat("MasterVolume", volume); //��������� ������ ���������
    }

    public void Quit()
    {
        Application.Quit();
    }
}
