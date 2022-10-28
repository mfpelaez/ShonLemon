﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    public CanvasGroup caughtBackgroundImageCanvasGroup;

    bool m_IsPlayerAtExit;
    bool m_IsPlayerCaught;
    float m_Timer;
    
    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }

    public void CaughtPlayer ()
    {
        m_IsPlayerCaught = true;
    }

    void Update ()
    {
        if (m_IsPlayerAtExit)
        {
            EndLevel (exitBackgroundImageCanvasGroup, false);
        }
        else if (m_IsPlayerCaught)
        {
            EndLevel (caughtBackgroundImageCanvasGroup, true );
        }
    }

    void EndLevel (CanvasGroup imageCanvasGroup, bool doRestart)
    {
        //if (!m_HasAudioPlayed)
        //{
          //  audioSource.Play();
            //m_HasAudioPlayed = true;
        //}
            
        m_Timer += Time.deltaTime;

        exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;

        imageCanvasGroup.alpha = m_Timer / fadeDuration;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            if (doRestart)
            {
                SceneManager.LoadScene (0);
            }
            else
            {
                Application.Quit ();
            }
        }
    }
}
