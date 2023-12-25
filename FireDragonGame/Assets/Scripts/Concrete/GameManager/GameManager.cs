using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] int _point;
   
    public static GameManager Instance { get; private set;}
    public event System.Action<int> PointEvent;
    private void Awake()
    {

        SingletonThisGameObject();

    }
    void Update()
    {
       
    }
    void SingletonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void Died()
    {
        StartCoroutine(RestartGame());
    }
    IEnumerator RestartGame()
    {
        _point = 0;
        Time.timeScale = 1;
        yield return SceneManager.LoadSceneAsync("Level1");
    }
    public void Point()
    {
        _point++;
        PointEvent?.Invoke(_point);
    }
   
   
}
