using UnityEngine;
using UnityEngine.UI;
public class ScrollView : MonoBehaviour

{
	public GameObject scrollView; // Reference to the scroll view game object
	public Button toggleButton; // Reference to the button that toggles the scroll view

	private bool isScrollViewVisible = false; // Flag to track the visibility of the scroll view

	private void Start()

	{
		// Set the initial visibility of the scroll view
		scrollView.SetActive(isScrollViewVisible);

		// Register the button click event
		toggleButton.onClick.AddListener(ToggleScrollView);
	}
		
	private void ToggleScrollView()
	{
		// Toggle the visibility of the scroll view
		isScrollViewVisible = !isScrollViewVisible;
		scrollView.SetActive(isScrollViewVisible);
	}
}