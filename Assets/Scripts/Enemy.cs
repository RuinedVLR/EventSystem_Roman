using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Enemy : MonoBehaviour
{
    public UnityEvent _enemyDeath;

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            _enemyDeath.Invoke();
            Instantiate(gameObject, new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
