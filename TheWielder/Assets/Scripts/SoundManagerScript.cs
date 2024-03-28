using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip VictorySound, DefeatSound;
    static AudioSource audioSrc;

    private void Start()
    {
        VictorySound = Resources.Load<AudioClip>("VictorySound");
        DefeatSound = Resources.Load<AudioClip>("DefeatSound");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string soundCase)
    {
        switch (soundCase)
        {
            case "Victory":
                audioSrc.PlayOneShot(VictorySound);
                break;
            case "Defeat":
                audioSrc.PlayOneShot(DefeatSound);
                break;
        }
    }
}
