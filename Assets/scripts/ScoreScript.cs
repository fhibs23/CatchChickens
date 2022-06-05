using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
	public GameObject nextLevel;
	public GameObject mainCanvas;
	public int score;
	[SerializeField] Text scoreText;
	ChickemMove script;
    // Start is called before the first frame update
	
	private void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "Chicken") {
			score++;
			other.gameObject.GetComponent<Animator>().SetTrigger("StopTrigger");
			script = other.gameObject.GetComponent<ChickemMove>();
			Destroy(script);
			Debug.Log(score);

		}
		if (score >= 8)
		{
			nextLevel.SetActive(true);
			mainCanvas.SetActive(false);
			Cursor.lockState = CursorLockMode.None;
		}
	}
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Chickens: " + score.ToString() + "/8";
		//Debug.Log(scoreText.text);
    }
}
