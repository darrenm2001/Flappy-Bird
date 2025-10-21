using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public static score instance;

    [SerializeField] private TextMeshProUGUI _CurrentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

private int _score;

private void Awake()
{
    if(instance == null)
    {
        instance = this;
    }

}
    private void Start()
    {
        _CurrentScoreText.text = _score.ToString();
        
        _highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _highScoreText.text = _score.ToString();
        }
    }

    public void UpdateScore()
    {
        _score++;
        _CurrentScoreText.text = _score.ToString();
        UpdateHighScore();
    }
}
