using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelMain : MonoBehaviour, IMenu
{
    [Header("Buttons")]
    [SerializeField] private Button btnTimer;

    [SerializeField] private Button btnMoves;
    [SerializeField] private Button btnRestart;
    
    private UIMainManager m_mngr;

    private void Awake()
    {
        btnMoves.onClick.AddListener(OnClickMoves);
        btnTimer.onClick.AddListener(OnClickTimer);
        btnRestart.onClick.AddListener(OnClickRestart);
    }

    

    private void OnDestroy()
    {
        if (btnMoves) btnMoves.onClick.RemoveAllListeners();
        if (btnTimer) btnTimer.onClick.RemoveAllListeners();
        if (btnRestart) btnRestart.onClick.RemoveAllListeners();
    }

    public void Setup(UIMainManager mngr)
    {
        m_mngr = mngr;
    }

    #region Button Events

    private void OnClickTimer()
    {
        m_mngr.LoadLevelTimer();
        PlayerPrefAdapter.PrevLevelMode = GameManager.eLevelMode.TIMER;
    }

    private void OnClickMoves()
    {
        m_mngr.LoadLevelMoves();
        PlayerPrefAdapter.PrevLevelMode = GameManager.eLevelMode.MOVES;
    }
    
    private void OnClickRestart()
    {
        if (PlayerPrefAdapter.PrevLevelMode == GameManager.eLevelMode.TIMER)
        {
            m_mngr.LoadLevelTimer();
        }
        else if (PlayerPrefAdapter.PrevLevelMode == GameManager.eLevelMode.MOVES)
        {
            m_mngr.LoadLevelMoves();
        }
    }

    #endregion

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
