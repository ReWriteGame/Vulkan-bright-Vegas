using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private SpriteRenderer box;
    [SerializeField] private GameObject win;
    [SerializeField] private GameObject lose;

    void Start()
    {
        Reset();
    }

    public void Reset()
    {
        box.enabled = true;
        win.SetActive(false);
        lose.SetActive(false);
    }

    public void SetWinState()
    {
        box.enabled = false;
        win.SetActive(true);
        lose.SetActive(false);
    }

    public void SetLoseState()
    {
        box.enabled = false;
        win.SetActive(false);
        lose.SetActive(true);
    }
}
