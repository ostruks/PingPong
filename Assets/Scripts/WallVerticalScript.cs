using UnityEngine;

public class WallVerticalScript : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if (gameObject.name == "WallVerticalLeft")
        {
            MainCameraScript.rightPlayerScore++;
        }
        else
        {
            MainCameraScript.leftPlayerScore++;
        }
    }
}
