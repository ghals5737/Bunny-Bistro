using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // �̵� �ӵ� (�ν����Ϳ��� ���� ����)
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 1. �Է� �ޱ� (WASD/����Ű) - ���� EventListener ����
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // 2. ���� ���� �̵� ó��
        rb.linearVelocity = moveInput.normalized * speed;
    }
}