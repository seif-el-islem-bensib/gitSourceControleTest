using UnityEngine;

public class Ihebbawel : MonoBehaviour
{
   public bool IsIhebbawelActive = false;
   public float IhebbawelDuration =12.0f;
    // This method can be called to toggle the state of Ihebbawel
    // and can be used to start a timer or perform other actions.
    public void StartIhebbawel()
    {
        if (IsIhebbawelActive)
        {
            Debug.Log("Ihebbawel is already active.");
            return;
        }
        IsIhebbawelActive = true;
        Debug.Log("Ihebbawel has been activated for " + IhebbawelDuration + " seconds.");
        
        // Here you could start a coroutine or timer to deactivate it after the duration
        Invoke("DeactivateIhebbawel", IhebbawelDuration);
    }
    private void DeactivateIhebbawel()
    {
        IsIhebbawelActive = false;
        Debug.Log("Ihebbawel has been deactivated.");
    }
    // Method to toggle Ihebbawel state
    public void ToggleIhebbawel()
    {
         IsIhebbawelActive = !IsIhebbawelActive;
         Debug.Log("Ihebbawel is now " + (IsIhebbawelActive ? "active" : "inactive"));
    }
}
