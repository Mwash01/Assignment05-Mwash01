using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    [SerializeField]
    public static string playerName;
    [SerializeField]
    public static int scoreNum;
    [SerializeField]
    public static float fallSpeed = 0.7f;

    public static bool music = true;

    public InputField userInput;
    public Dropdown Speed;
    public Toggle MusicToggle;

    void Start() {
        userInput.GetComponent<InputField>().text = PlayerPrefs.GetString("Name");

        Speed.GetComponent<Dropdown>().value = PlayerPrefs.GetInt("Speed");

        if (!PlayerPrefs.HasKey("Music")) {
            PlayerPrefs.SetInt("Music", 1);
            MusicToggle.isOn = true;
        }
        else {
            if (PlayerPrefs.GetInt("Music") == 0) {
                MusicToggle.isOn = false;
            }
            else {
                MusicToggle.isOn = true;
            }
        }
    }

    public void InputName() {
        playerName = userInput.text;
        PlayerPrefs.SetString("Name", playerName);
    }
    public void ChangeSpeed() {
        switch(Speed.value) {
            case 0:
                fallSpeed = 0.8f;
                PlayerPrefs.SetFloat("Speed", Speed.value);
                break;
            case 1:
                fallSpeed = 1.15f;
                PlayerPrefs.SetInt("Speed", Speed.value);
                break;
            case 2:
                fallSpeed = 2f;
                PlayerPrefs.SetInt("Speed", Speed.value);
                break;
        }
    }

    public void ToggleMusic() {
        if (MusicToggle.isOn) {
            PlayerPrefs.SetInt("Music", 1);
            music = true;
        }
        if (!MusicToggle.isOn) {
            PlayerPrefs.SetInt("Music", 0);
            music = false;
        }
    }
}
