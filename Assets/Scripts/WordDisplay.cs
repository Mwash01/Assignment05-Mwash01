using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public GameObject PauseCanvas;

    public void SetWord(string word) {
        text.text = word;
    }

    public void RemoveLetter() {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord() {
        Destroy(gameObject);
    }

    private void Update() {
        transform.Translate(0, -Data.fallSpeed * Time.deltaTime, 0f);
        if(transform.position.y <= -5.8) {
            Destroy(gameObject);
            SceneManager.LoadScene("Credits");
        }
    }
}
