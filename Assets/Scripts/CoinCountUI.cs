using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCountUI : MonoBehaviour
{
    int coinCount;
    Text coinCountText;

	// Use this for initialization
	void Start ()
    {
        coinCountText = gameObject.GetComponent<Text>();
        coinCount = 0;
	}
	
	public void AddCoin ()
    {
        coinCount += 1;
        coinCountText.text = "Coins: " + coinCount.ToString();
    }
}
