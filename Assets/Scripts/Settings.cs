using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class Settings : MonoBehaviour {


    public AudioMixer am;
    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("masterVolume", sliderValue);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
