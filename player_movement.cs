using UnityEngine;

[SelectionBase]
public class player_movement : MonoBehaviour
{
    #region Editor Data
    [Header("Movement Attributes")]
    [SerializeField] float _moveSpeed = 50f;

    [Header("Dependencies")]
    [SerializeField] Rigidbody2D _rb;
    #endregion
    #region Internal Data
    private Vector2 _moveDir = Vector2.zero;
    #endregion

    #region Tick
    private void Update()
    {
        GatherInput();
    }

    private void FixedUpdate()
    {
        MovementUpdate();
    }
    #endregion

    #region Input Logic
    private void GatherInput()
    {
        _moveDir.x = Input.GetAxisRaw("Horizontal");
        _moveDir.y = Input.GetAxisRaw("Vertical");

        print(_moveDir);
    }
    #endregion

    #region Movement Logic
    private void MovementUpdate()
    {
        _rb.linearVelocity = _moveDir * _moveSpeed * Time.fixedDeltaTime;
    }
    #endregion
}
