using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    public AudioSource audioSource;
    public AudioClip collectSound;

    // 2. Здоров`я гравця (Поля)
    private int health = 10;

    // 2. Отримання урону (Метод)
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Health: " + health);
    }

    public void CollectCoins() 
    {
        //1. Додавання монеток
        coins++;

        //2. Вiдтворення звуку при зборi монеток
        audioSource.PlayOneShot(collectSound);

        //3. Друкування iнфи.
        print("Coins: " + coins);
    }
}
