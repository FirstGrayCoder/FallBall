using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource Sound;
    private GameObject obj;
    // Start is called before the first frame update
    private void Start()
    {
        obj = GameObject.FindWithTag("Music");
        Sound = (AudioSource)obj.GetComponent("AudioSource");
    }
    public void SoundOn()
    {
        Sound.Play();
    }
        public void SoundOff()
    {
        Sound.Pause();
    }
}
