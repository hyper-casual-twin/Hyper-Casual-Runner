using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    private const string LOADING_LEVEL = "LoadingLevel";

    /*[SerializeField] private GameObject*/
    private void Awake()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt(LOADING_LEVEL, 1));
    }
}
