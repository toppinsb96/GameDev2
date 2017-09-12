using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {
	public Health playerHealth;
	public Transform canvas;
	public Transform bone;

	void Update() {
		if(playerHealth.healthPoints <= 0)
		{
			if(canvas.gameObject.activeInHierarchy == false)
			{
				canvas.gameObject.SetActive(true);
				bone.gameObject.SetActive(false);
				Time.timeScale = 0;
			} else
			{
				canvas.gameObject.SetActive(false);
				bone.gameObject.SetActive(true);
				Time.timeScale = 1;
			}
		}
	}
}
