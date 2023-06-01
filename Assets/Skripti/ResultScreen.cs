using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ResultScreen : MonoBehaviour
{

	public GameObject[] objectsToCollect; // Array of objects to collect
	public float maxTime = 120f; // Maximum time allowed to collect all objects
	public GameObject endImage; // End image with stars
	public Image[] starImages; // Images for the stars
	public Button playAgainButton; // Play Again button

	private int collectedObjectsCount = 0; // Counter for collected objects
	private float timer = 0f; // Timer for tracking time
	private bool gameFinished = false; // Flag to check if the game is finished

	private void Start()

	{

		// Hide the end image and stars initially
		endImage.SetActive(false);
		foreach (var starImage in starImages)
		{
			starImage.gameObject.SetActive(false);

		}
		// Disable the Play Again button
		playAgainButton.interactable = false;
	}
	private void Update()
	{
		// Check if the game is finished
		if (gameFinished)
			return;
		
		// Update the timer
		timer += Time.deltaTime;
		// Check if all objects are collected
		if (collectedObjectsCount >= objectsToCollect.Length)
		{
			// Game finished
			gameFinished = true;
			// Calculate the number of stars based on time

			int starCount = 1;

			if (timer <= maxTime * 0.80f)
				starCount = 3;
			
			else if (timer <= maxTime * 0.120f)

				starCount = 2;

			// Show the end image and stars
			endImage.SetActive(true);
			for (int i = 0; i < starCount; i++)
			{
				starImages[i].gameObject.SetActive(true);
			}

		}
	}

	public void CollectObject()
	{
		// Increase the collected objects count
		collectedObjectsCount++;
	}
		
	public void PlayAgain()
	{
		// Reload the current scene to restart the game
		UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
	}
}