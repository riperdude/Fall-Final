using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioSource _coinAudio;

    void Start()
    {
        _coinAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collected the coin.");
            GameObject.Find("Canvas").GetComponent<UIManager>().UpdateCoinCount();
            Destroy(this.gameObject);
        }
    }
}
