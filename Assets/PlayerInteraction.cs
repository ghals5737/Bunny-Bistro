using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private GameObject currentCrop; // 현재 닿아있는 작물

    void Update()
    {
        // 작물 옆에서 Space를 누르면 뽑기
        if (currentCrop != null && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("당근을 뽁! 하고 뽑았습니다.");
            Destroy(currentCrop); // 당근 오브젝트 삭제 (DOM 제거와 유사)
            currentCrop = null;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Crop"))
        {
            currentCrop = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Crop"))
        {
            currentCrop = null;
        }
    }
}