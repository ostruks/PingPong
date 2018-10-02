using UnityEngine;

public class RacketScript : MonoBehaviour {

    public float speed = 30;
    public string axisName = "Vertical";

	void FixedUpdate () {
        float v = Input.GetAxisRaw(axisName);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
	}
}
