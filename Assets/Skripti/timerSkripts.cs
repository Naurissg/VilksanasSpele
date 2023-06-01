using UnityEngine;
using UnityEngine.UI;
public class timerSkripts : MonoBehaviour

{
	public Text timerText;
	private bool isRunning = false;
	private float elapsedTime = 0f;

	private void Start()
	{
		UnityEditor.EditorApplication.playmodeStateChanged += ModeChanged;
	}

	private void ModeChanged()
	{
		if (UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode && !UnityEditor.EditorApplication.isPlaying)
		{
		}
	}

	private void Update()
	{
		if (!isRunning)
		{
			elapsedTime += Time.deltaTime;
			UpdateTimerUI(elapsedTime);
		}
	}
	private void UpdateTimerUI(float elapsedTime)

	{
		float minutes = Mathf.FloorToInt (elapsedTime / 60);
		float seconds =  Mathf.FloorToInt (elapsedTime % 60);
		timerText.text = string.Format ("{0:00}:{1:00}", minutes, seconds);
	
	}
}