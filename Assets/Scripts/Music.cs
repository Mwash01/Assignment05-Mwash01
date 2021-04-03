using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource Audio;
    private void Start() {
        if (Data.music) {
            Audio.enabled = true;
        }
        else {
            Audio.enabled = false;
        }
    }
}
