using UnityEngine;
using System.Collections;

public class CameraRig : MonoBehaviour {

    public Transform Target;
    public float Low;
    public float High;

	void Start () {
	
	}
	
	void Update () {
        transform.position = new Vector3(Target.position.x, Clamp(Target.position.y, Low, High), transform.position.z);
	}

    private float Clamp(float value, float low, float high)
    {
        return Mathf.Min(Mathf.Max(value, low), high);
    }
}
