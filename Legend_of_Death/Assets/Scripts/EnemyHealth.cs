using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour, ITakeDamage, IDie
{
    public EnemyController enemy;
    public Slider slider;
    public Color low;
    public Color high;
    //public Vector3 Offset;
    public float xOffset; //x offset for camera
    public float yOffset; // y offset for camera

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(enemy.transform.position.x + xOffset, enemy.transform.position.y + yOffset, transform.position.z); //Setting the position of the health bar 
    }
    public void SetMaxHealth(int health, float maxHealth)
    {
        slider.gameObject.SetActive(health < maxHealth);
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        
        slider.value = health;
        slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(low, high, slider.normalizedValue); //Changing the color of the health from max to low health
    }

    public void TakeDamage()
    {
        
    }

    public void Die()
    {
        
    }
}
