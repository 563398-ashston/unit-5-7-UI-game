using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class MenuManager : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;
    public Toggle muteMusicButton;

    public AudioMixer mixer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.instance.PlayMusic("background music");
        


        //read the bool for the mute button
        if (PlayerPrefs.GetInt("mute") == 0)
        {
            AudioManager.instance.musicMute = false;
        }
        else
        {
            AudioManager.instance.musicMute = true;
        }


        musicSlider.value = PlayerPrefs.GetFloat("musicVolume", 1f);
        musicSlider.onValueChanged.AddListener(SetMusicVolume);

        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume", 1f);
        sfxSlider.onValueChanged.AddListener(SetSFXVolume);

        muteMusicButton.isOn = AudioManager.instance.musicMute;



    }

    // Update is called once per frame
    void Update()
    {
        //check for mute being pressed

        DoMusicMute();
        
    }

    void SetMusicVolume( float val )
    {
        if( AudioManager.instance.musicMute )
        {
            val = 0.0001f;
        }
        mixer.SetFloat(volumeSettings.MIXER_MUSIC, Mathf.Log10(val) * 20);
        PlayerPrefs.SetFloat("musicVolume", val);


        

    }

    void SetSFXVolume(float val)
    {
        mixer.SetFloat(volumeSettings.MIXER_SFX, Mathf.Log10(val) * 20);
        PlayerPrefs.SetFloat("sfxVolume", val);

    }


    void DoMusicMute()
    {
        float vol;
        if ( AudioManager.instance.musicMute == true )
        {
            vol =  0.0001f;

        }
        else
        {
            vol = musicSlider.value;
        }

        mixer.SetFloat(volumeSettings.MIXER_MUSIC, Mathf.Log10(vol) * 20);
        PlayerPrefs.SetInt("mute", (AudioManager.instance.musicMute ? 1 : 0 ));

    }
        
        
    
       
    
}
