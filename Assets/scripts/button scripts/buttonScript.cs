using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
    public TMP_Text buttonText;
    AudioSource audioSource;
    
    


    //loads level 1
    public void StartGameButton()
    {
        //buttonText.text = "game starting";
        //FindFirstObjectByType<AudioManager>().PlaySFX("menusfx"); 
        SceneManager.LoadScene("level1");
        //PlaySoundEffect();
    }


    //loads level 2 
    public void StartGameButton2()
    {
        //buttonText.text = "game starting";
        //FindFirstObjectByType<AudioManager>().PlaySFX("menusfx"); 
        SceneManager.LoadScene("level2");
        //PlaySoundEffect();
    }

    //returns to the frontend
    public void ReturnToMenu()
    {
        //buttonText.text = "returning...";
        //FindFirstObjectByType<AudioManager>().PlaySFX("menusfx");
        SceneManager.LoadScene("Frontend");
        //PlaySoundEffect();
    }

    //closes the game
    public void QuitTheGame()
    {
        Application.Quit();
    }

    //mute music (sfx untouched) 
    public void MuteMusic( bool mute )
    {
        AudioManager.instance.musicMute = mute;
        //print("music mute=" + AudioManager.instance.musicMute);
    }

    public void PlaySFX ()
    {
        AudioManager.instance.PlaySFX("button press sfx");
    }
}
