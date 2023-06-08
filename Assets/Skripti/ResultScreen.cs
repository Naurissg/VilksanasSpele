using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultScreen : MonoBehaviour
{

	public GameObject[] objectsToCollect; // Array objekti kas tiek saglabati
	public GameObject endImage; // Beigu ekrans ar zvaigznem
	public Image[] starImages; // Bilde zvaigznem
	public Objekti objektuSkripts;
	private int starCount = 0;
	private int collectedObjectsCount = 11; // Savākto priekšmetu skaitītājs
	private float timer; // Taimeris laika izsekošanai
	public bool gameFinished; // parbaude vai sp'ele ir beigusies

	private void Start()
	{
	timer = 0f;
		gameFinished = false;
		endImage.SetActive(false);
		foreach (var starImage in starImages)
		{
			starImage.gameObject.SetActive(false);

		}
	}
	private void Update()
	{
		// Check if the game is finished
		if (gameFinished)
		return;
		else 	 
		// Update the timer
		timer += Time.deltaTime;
		// Check if all objects are collected
		if (objektuSkripts.sk == 11)
		{
			// Game finished
			gameFinished = true;
			// Calculate the number of stars based on time

			if (timer <= 90)
				starCount = 3;
			
			else if (timer >= 90 && timer <= 150)
				starCount = 2;
			
			else if (timer >= 150)
				starCount = 1;
			
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
		
	}