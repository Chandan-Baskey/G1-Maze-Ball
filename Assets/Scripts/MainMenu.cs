using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioClip clickSound;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PlayClick()
    {
        if (clickSound != null)
            AudioSource.PlayClipAtPoint(clickSound, Camera.main.transform.position);
    }

    public void StartGame()
    {
        PlayClick();
        
        StartCoroutine(LoadWithDelay(2));

        //SceneManager.LoadScene(2);
    }

    public void LevelMenu()
    {
        PlayClick();
        StartCoroutine(LoadWithDelay(1));
        //SceneManager.LoadScene(1);
    }

     public void QuitGame()
    {
        PlayClick();
        Application.Quit();
        Debug.Log("Quit");
    }
    private IEnumerator LoadWithDelay(int sceneIndex)
    {
        yield return new WaitForSeconds(0.2f); // wait for click sound
        SceneManager.LoadScene(sceneIndex);
    }
}
