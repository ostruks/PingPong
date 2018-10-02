using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCameraScript : MonoBehaviour {

    public static int leftPlayerScore = 0;
    public static int rightPlayerScore = 0;
    public static float Timer = 0;

    void Update()
    {
        Timer += Time.deltaTime;
    }

    void ixedUpdate()
    {
        if(leftPlayerScore == 5 || rightPlayerScore == 5)
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 40;
        myStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(200, 10, 100, 25), leftPlayerScore.ToString() + " : " + rightPlayerScore.ToString(), myStyle);
        if (Timer < 2)
        {
            GUI.Label(new Rect(400, 10, 100, 25), "Новая партия!", myStyle);
        }
    }
}
