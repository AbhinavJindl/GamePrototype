using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BulletCountManager : MonoBehaviour
{
    public static BulletCountManager instance;

    public int numAllowedBullets = 5;
    private int numBulletsShot = 0;

    public TextMeshProUGUI bulletText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        bulletText.text = "Bullets Remaining: " + (numAllowedBullets - numBulletsShot);
    }

    public bool BulletsLeft()
    {
        return numBulletsShot < numAllowedBullets;

    }

    public void ShootBullet()
    {
        if (BulletsLeft()) {
            numBulletsShot += 1;
            UpdateScoreUI();
        }
    }

    private void UpdateScoreUI()
    {
        bulletText.text = "Bullets Remaining: " + (numAllowedBullets - numBulletsShot);
    }
}
