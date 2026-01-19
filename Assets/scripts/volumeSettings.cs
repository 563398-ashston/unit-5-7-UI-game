using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class volumeSettings : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;

    public const string MIXER_MUSIC = "MusicVolume";
    public const string MIXER_SFX = "SFXVolume";

    private void Awake()
    {
    }

    private void Start()
    {
        //musicSlider.value = PlayerPrefs.GetFloat(audioManager.MUSIC_KEY, 1f);
        //sfxSlider.value = PlayerPrefs.GetFloat(audioManager.SFX_KEY, 1f);

        print("audiomanager start");
    }

    private void OnDisable()
    {
    }

    void SetMusicVolume(float value)
    {
        PlayerPrefs.SetFloat("musicVolume", value);
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value) * 20);
    }

    void SetSFXVolume(float value)
    {
        PlayerPrefs.SetFloat("sfxVolume", value);
        mixer.SetFloat(MIXER_SFX, Mathf.Log10(value) * 20);
    }
}
