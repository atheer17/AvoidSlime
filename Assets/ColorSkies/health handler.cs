using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameHandler : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    HealthSystem healthSystem = new HealthSystem(100);
    public void Update()
    {
        slider.value = healthSystem.GetHealthPercentage();
    }
    private void OneCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        { healthSystem.Damage(10); }
    }
    private void OnTriggerEnter(Collision other)
    {
        if (other.gameObject.tag == "Heal")
        { healthSystem.Heal(10); }
    }
}
