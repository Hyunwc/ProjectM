using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Weapon;

public class SoundManager : MonoBehaviour
{
    // ΩÃ±€≈Ê ∆–≈œ
    public static SoundManager Instance { get; set; }

    public AudioSource ShootingChannel;
    
    public AudioClip EagleShot;
    public AudioClip ScarShot;

    public AudioSource reloadingSoundEagle;
    public AudioSource reloadingSoundScar;

    public AudioSource emptyMagazineSoundDEagle;

    public AudioSource throwablesChannel;
    public AudioClip grenadeSound;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void PlayShootingSound(WeaponModel weapon)
    {
        switch(weapon)
        {
            case WeaponModel.PistolEagle:
                ShootingChannel.PlayOneShot(EagleShot);
                break;
            case WeaponModel.Scar:
                ShootingChannel.PlayOneShot(ScarShot);
                break;
        }
    }

    public void PlayReloadSound(WeaponModel weapon)
    {
        switch (weapon)
        {
            case WeaponModel.PistolEagle:
                reloadingSoundEagle.Play();
                break;
            case WeaponModel.Scar:
                reloadingSoundScar.Play();
                break;
        }
    }

}
