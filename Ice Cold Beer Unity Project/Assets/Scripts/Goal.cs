using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Detects when the ball touches the goal, and then wins the level.
/// </summary>
public class Goal : MonoBehaviour
{
    public GameObject winText;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched trigger.");
        if (collision.tag == "Player" && !GameOver.IsGameOver)
        {
            winText.SetActive(true);
            // cue sound effect here
            audioSource.Play();
            Debug.Log("The player has entered the goal!");
        }
    }

}
