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
	
	public void AddCoin (int coinValue)
    {
        coinCount += coinValue;
        coinCountText.text = "Coins: " + coinCount.ToString();
        StartCoroutine(TextColorFlash());
    }

    IEnumerator TextColorFlash()
    {
        coinCountText.color = Color.yellow;
        yield return new WaitForSeconds(0.3F);
        coinCountText.color = Color.gray;
    }
}
