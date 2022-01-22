using DragonGame.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DragonGame.Movements {
    [RequireComponent(typeof(Rigidbody2D))]
    public class StaticMover : MonoBehaviour
    {
        [SerializeField] float MoveSpeed = 5f;
        [SerializeField] DirectEnum direction;
        Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
        private void OnEnable()
        {
            _rigidbody2D.velocity = NewDirecton()* MoveSpeed;
        }
        private Vector2 NewDirecton()
        {
            Vector2 selectDirection;

            if (direction == DirectEnum.Left)
            {
                selectDirection = Vector2.left;
            }
            else
            {
                selectDirection = Vector2.right;
            }
            return selectDirection;
        }
    }
}


