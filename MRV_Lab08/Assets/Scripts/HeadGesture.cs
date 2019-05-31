using UnityEngine;
using System.Collections;

public class HeadGesture : MonoBehaviour {
	public bool isFacingDown = false;
	public bool isMovingDown = false;

	private float sweepRate = 20.0f;
	private float previousCameraAngle;

	void Start() {
		previousCameraAngle = CameraAngleFromGround ();
    }

	// Update is called once per frame
	void Update () {
		isFacingDown = DetectFacingDown ();
		isMovingDown = DetectMovingDown ();
    }

    private bool DetectFacingDown() {
		return (CameraAngleFromGround () < 60.0f);
	}

	private bool DetectMovingDown() {
		float angle = CameraAngleFromGround ();
		float deltaAngle = previousCameraAngle - angle;
		previousCameraAngle = angle;
        bool gg = deltaAngle > 0.0;

        return gg;
	}

	private float CameraAngleFromGround() {
        //Debug.Log("CameraAngleFromGround: " + Vector3.Angle(Vector3.down, Camera.main.transform.rotation * Vector3.forward).ToString("F2"));
        return Vector3.Angle (Vector3.down, Camera.main.transform.rotation * Vector3.forward);
	}
}
