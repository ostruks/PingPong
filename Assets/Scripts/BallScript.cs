using UnityEngine;

public class BallScript : MonoBehaviour {

    public float speed = 30.0f;
    private float spawnX, spawnY;

    void Start () {
        spawnX = transform.position.x;
        spawnY = transform.position.y;
        this.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    void Update()
    {
        if (MainCameraScript.leftPlayerScore == 5 || MainCameraScript.rightPlayerScore == 5)
        {
            transform.position = new Vector2(spawnX, spawnY);
            speed *= 1.20f;
            if (speed > 63)
            {
                speed = 30.0f;
            }
            this.GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
            MainCameraScript.leftPlayerScore = 0;
            MainCameraScript.rightPlayerScore = 0;
            MainCameraScript.Timer = 0;
        }
    }

    float Hitfactor(Vector2 ballPosition, Vector2 racketPosition, float racketHeight)
    {
        return (ballPosition.y - racketPosition.y) / racketHeight;
    }
}
