
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int coins;
    public AudioSource audioSource;
    public AudioClip collectSound;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }

    }

    // 2. Здоров`я гравця (Поля)
    private int health = 10;
    public AudioClip damageSound;

    // 2. Отримання урону (Метод)
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);
            print("Health: " + health);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
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
