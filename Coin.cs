using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
       Player player = other.GetComponent<Player>();

        player.CollectCoins();
        Destroy(gameObject);
    }
}
