using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Needed for working with Text components
using UnityEngine.UI;

public class HighScores : MonoBehaviour {

    // Text components used to display the high scores
    public List<Text> highScoreDisplays = new List<Text>();

    // Internal data for score valies
    private List<int> highScoreData = new List<int>();

	// Use this for initialization
	void Start ()
    {
        // Load the high score data from the PlayerPrefs
        LoadHighScoreData();

        // Update the visual display
        UpdateVisualDisplay();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LoadHighScoreData()
    {
        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {
            // Using the loop index, get the name for our PlayerPrefs key
            string prefsKey = "highScore" + i.ToString();

            // Use this key to get the high score value from PlayerPrefs
            int highScoreValue = PlayerPrefs.GetInt(prefsKey, 0);

            // Store this score value in our internal data list
            highScoreData.Add(highScoreValue);
        }
    }

    private void UpdateVisualDisplay()
    {
        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {
            // Find the specific text and numbers in our list
            // Set the text to the numerical score
            highScoreDisplays[i].text = highScoreData[i].ToString();
        }
    }
}
