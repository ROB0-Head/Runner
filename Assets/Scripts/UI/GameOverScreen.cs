using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[RequireComponent(typeof(CanvasGroup))]
public class GameOverScreen : MonoBehaviour
{
  [SerializeField] private Button _buttonReset;
  [SerializeField] private Button _buttonExit;
  [SerializeField] private Player _player;
  
  private CanvasGroup _gameOverGroup;
  
  private void Start()
  {
    _gameOverGroup = GetComponent<CanvasGroup>();
    _gameOverGroup.alpha = 0;
  }

  private void OnEnable()
  {
    _player.Died += OnDied;
    _buttonReset.onClick.AddListener(OnResetButtonClick);
    _buttonExit.onClick.AddListener(OnExitButtonClick);
  }

  private void OnDisable()
  {
    _player.Died += OnDied;
    _buttonReset.onClick.RemoveListener(OnResetButtonClick);
    _buttonExit.onClick.RemoveListener(OnExitButtonClick);
  }

  private void OnDied()
  {
    _gameOverGroup.alpha = 1;
    Time.timeScale = 0;
  }

  private void OnResetButtonClick()
  {
    Time.timeScale = 1;
    SceneManager.LoadScene(0);
  }
  private void OnExitButtonClick()
  {
    Application.Quit();
  }
}

