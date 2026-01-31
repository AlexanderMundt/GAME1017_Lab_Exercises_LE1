using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class SoundManager : Singleton<SoundManager>
{
    [SerializeField] private AudioSource musicSource, sfxSource;

    private void Start()
    {
        if (musicSource)
        {
            sfxSource.loop = true;
            musicSource.Play();
        }

        if (sfxSource)
        {
            sfxSource.loop = true;
            sfxSource.Play();
        }
    }

    public void ChangeMusicVolume(float newVolume)
    {
        musicSource.volume = newVolume;
    }

    public void ChangeSfxVolume(float newVolume)
    {
        sfxSource.volume = newVolume;
    }
}
