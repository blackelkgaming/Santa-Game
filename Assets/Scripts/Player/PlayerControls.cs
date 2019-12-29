using System;
using System.Collections;
using System.Collections.Generic;
using Classes;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    // private GameObject _player;
    private Rigidbody _playerRb;
    private FixedJoystick _joystick;
    public JumpButton jumpButton;
    public ShootButton shootButton;
    
    public GameObject[] presents = new GameObject[4];
    
    public Material redMat;
    public Material greenMat;

    private float _movementSpeed = 10.0f;
    private bool _isGrounded = true;
    private bool _thrown = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        _playerRb = GetComponent<Rigidbody>();
        _joystick = FindObjectOfType<FixedJoystick>();
        
        if (shootButton == null)
        {
            Debug.Log("Shoot button is null");
        }

        if (jumpButton == null)
        {
            Debug.Log("Jump Button is null");
        }

    }


    private void FixedUpdate()
    {
        Move(_playerRb);
        
        if (shootButton.getPressed())
        {
            Throw();
        }

        if (jumpButton.getPressed())
        {
            Jump();
        }
    }

    private void Move(Rigidbody _rb)
    {
        _rb.velocity = new Vector3(_joystick.Horizontal * _movementSpeed, _rb.velocity.y, 0);
    }

    private void Jump()
    {
        if (_isGrounded)
        {
            _playerRb.AddForce(new Vector3(0.0f, 3.0f, 0.0f), ForceMode.Impulse);
            _isGrounded = false;
        }
    }


    private void Throw()
    {
        if(!_thrown)
        {
            Vector3 playerPosition = _playerRb.transform.position;
            Instantiate(presents[RandNum.GetNumTo(4)], new Vector3(playerPosition.x, (playerPosition.y + 0.5f), playerPosition.y), Quaternion.identity);
            _thrown = true;
            StartCoroutine(throwTimer());
        }
    }

    IEnumerator throwTimer()
    {
        yield return new WaitForSeconds(0.5f);
        _thrown = false;
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag.Equals("Ground"))
        {
            _isGrounded = true;
        }
    }
}
