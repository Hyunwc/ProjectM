using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // ΩÃ±€≈Ê ∆–≈œ
    public static SoundManager Instance { get; set; }

    public AudioSource shootingSoundDEagle;
    public AudioSource reloadingSoundDEagle;
    public AudioSource emptyMagazineSoundDEagle;

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
}
