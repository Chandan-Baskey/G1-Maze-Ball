using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvLMenu : MonoBehaviour
{
    //public void StartGame()
    //{
    //   SceneManager.LoadScene(2);
    //}
    // public void BackMainMenu()
    //{
    //   SceneManager.LoadScene(0);
    //}
    //public void BackL()
    //{
    //    SceneManager.LoadScene("BackL");
    //}
    //public void NextL()
    //{
    //    SceneManager.LoadScene("NextL");
    //}
    //public void Level1()
    //{
    //    SceneManager.LoadScene(2);
    //}
    //public void Level2()
    //{
    //    SceneManager.LoadScene(3);
    //}
    //public void Level3()
    //{         
    //    SceneManager.LoadScene(4);
    //}
    //public void Level4()
    //{         
    //    SceneManager.LoadScene(5);
    //}
    //public void Level5()
    //{         
    //    SceneManager.LoadScene(6);
    //}
    //public void Level6()
    //{         
    //    SceneManager.LoadScene(7);
    //}
    //public void Level7()
    //{         
    //    SceneManager.LoadScene(8);
    //}
    // public void Level8()
    //{         
    //    SceneManager.LoadScene(9);
    //}
    // public void Level9()
    //{         
    //    SceneManager.LoadScene(10);
    //}
    // public void Level10()
    //{         
    //    SceneManager.LoadScene(11);
    //}
    //public void Level11()
    //{         
    //    SceneManager.LoadScene(12);
    //}
    // public void Level12()
    //{         
    //    SceneManager.LoadScene(13);
    //}
    // public void Level13()
    //{         
    //    SceneManager.LoadScene(14);
    //}
    // public void Level14()
    //{         
    //    SceneManager.LoadScene(15);
    //}
    // public void Level15()
    //{         
    //    SceneManager.LoadScene(16);
    //}
    // public void Level16()
    //{         
    //    SceneManager.LoadScene(17);
    //}
    // public void Level17()
    //{         
    //    SceneManager.LoadScene(18);
    //}
    // public void Level18()
    //{         
    //    SceneManager.LoadScene(19);
    //}
    // public void Level19()
    //{         
    //    SceneManager.LoadScene(20);
    //}
    // public void Level20()
    //{         
    //    SceneManager.LoadScene(21);
    //}

    [SerializeField] private AudioClip clickSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void PlayClick()
    {
        if (clickSound != null)
            AudioSource.PlayClipAtPoint(clickSound, Camera.main.transform.position);
    }

    private IEnumerator LoadWithDelay(int sceneIndex)
    {
        yield return new WaitForSeconds(0.15f);
        SceneManager.LoadScene(sceneIndex);
    }

    private IEnumerator LoadWithDelay(string sceneName)
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(sceneName);
    }

    public void StartGame() { PlayClick(); StartCoroutine(LoadWithDelay(2)); }
    public void BackMainMenu() { PlayClick(); StartCoroutine(LoadWithDelay(0)); }
    public void BackL() { PlayClick(); StartCoroutine(LoadWithDelay("BackL")); }
    public void NextL() { PlayClick(); StartCoroutine(LoadWithDelay("NextL")); }

    public void Level1() { PlayClick(); StartCoroutine(LoadWithDelay(2)); }
    public void Level2() { PlayClick(); StartCoroutine(LoadWithDelay(3)); }
    public void Level3() { PlayClick(); StartCoroutine(LoadWithDelay(4)); }
    public void Level4() { PlayClick(); StartCoroutine(LoadWithDelay(5)); }
    public void Level5() { PlayClick(); StartCoroutine(LoadWithDelay(6)); }
    public void Level6() { PlayClick(); StartCoroutine(LoadWithDelay(7)); }
    public void Level7() { PlayClick(); StartCoroutine(LoadWithDelay(8)); }
    public void Level8() { PlayClick(); StartCoroutine(LoadWithDelay(9)); }
    public void Level9() { PlayClick(); StartCoroutine(LoadWithDelay(10)); }
    public void Level10() { PlayClick(); StartCoroutine(LoadWithDelay(11)); }
    public void Level11() { PlayClick(); StartCoroutine(LoadWithDelay(12)); }
    public void Level12() { PlayClick(); StartCoroutine(LoadWithDelay(13)); }
    public void Level13() { PlayClick(); StartCoroutine(LoadWithDelay(14)); }
    public void Level14() { PlayClick(); StartCoroutine(LoadWithDelay(15)); }
    public void Level15() { PlayClick(); StartCoroutine(LoadWithDelay(16)); }
    public void Level16() { PlayClick(); StartCoroutine(LoadWithDelay(17)); }
    public void Level17() { PlayClick(); StartCoroutine(LoadWithDelay(18)); }
    public void Level18() { PlayClick(); StartCoroutine(LoadWithDelay(19)); }
    public void Level19() { PlayClick(); StartCoroutine(LoadWithDelay(20)); }
    public void Level20() { PlayClick(); StartCoroutine(LoadWithDelay(21)); }
}
