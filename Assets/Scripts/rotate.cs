using UnityEngine;

public class rotate : MonoBehaviour {

	void Update () {
        gameObject.transform.Rotate(0, 5, 5, Space.World);
	}
}
