using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //public static int playerHealthMax;
    Rigidbody rb;
    //AudioSource audioSource;
    //public AudioClip sfx1;  // sound effect asset from sfx folder 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //LevelManager.instance.SetHighScore(0);
        rb = GetComponent<Rigidbody>();
        //playerHealthMax = 100;
        //audioSource = GetComponent<AudioSource>();
        /*
        if (PlayerPrefs.HasKey("high") == true)
        {
            LevelManager.instance.highScore = PlayerPrefs.GetInt("high");
        }
        else
        {
            PlayerPrefs.SetInt("high", 1000);
        }
        */
    }
        
    // Update is called once per frame
    void Update()
    {
        float xvel, yvel, zvel;

        xvel = rb.linearVelocity.x;
        yvel = rb.linearVelocity.y;
        zvel = rb.linearVelocity.z;

        if (Input.GetKey("w"))
        {
            xvel = 10;
            print("player moving forwards");
            //    LevelManager.instance.playerScore += 1;
        }


        if (Input.GetKey("s"))
        {
            xvel = -10;
            print("player moving left");
            // LevelManager.instance.playerScore += 1;
        }


        if (Input.GetKey("d"))
        {
            zvel = -10;
            print("player moving right");
            //LevelManager.instance.playerScore += 1;
        }


        if (Input.GetKey("a"))
        {
            zvel = 10;
            print("player moving backwards");
            //LevelManager.instance.playerScore += 1;

        }


        rb.linearVelocity = new Vector3(xvel, yvel, zvel);


        rb.linearVelocity = new Vector3(rb.linearVelocity.x * 0.7f, rb.linearVelocity.y, rb.linearVelocity.z * 0.7f);


        //debug change score
        /*
        if (Input.GetKey("2"))
        {
            LevelManager.instance.playerScore += 10;
        }

        if (Input.GetKey("1"))
        {
            LevelManager.instance.playerScore -= 10;
        }

        if (LevelManager.instance.playerScore > LevelManager.instance.highScore)
        {
            LevelManager.instance.highScore = LevelManager.instance.playerScore;
            PlayerPrefs.SetInt("high", LevelManager.instance.highScore);

        }
        */

    }
   
    /*
    //debug text output
    private void OnGUI()
    {
        //read variable from LevelManager singleton
        int score = LevelManager.instance.GetHighScore();

        string text = "High score: " + LevelManager.instance.highScore;


        text += "       Player score: " + LevelManager.instance.playerScore;
        text += "\nPlayer health: " + LevelManager.instance.playerHealth;


        // define debug text area
        GUI.contentColor = Color.white;
        GUILayout.BeginArea(new Rect(10f, 10f, 1600f, 1600f));
        GUILayout.Label($"<size=40>{text}</size>");
        GUILayout.EndArea();
    }
    */
}