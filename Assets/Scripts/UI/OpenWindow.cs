using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class OpenWindow : MonoBehaviour
    {
        private static readonly int Open = Animator.StringToHash("Open");
        
        [SerializeField] private Button _openButton;
        [SerializeField] private Animator _animator;
        
        
    
        private void Awake()
        {
            _openButton.onClick.AddListener(WindowAnimation);
        }

        private void WindowAnimation()
        {
            if (_animator.GetBool(Open))
            {
                _animator.SetBool(Open, false);
                return;
            }
            _animator.SetBool(Open, true);
        }

        private void OnDestroy()
        {
            _openButton.onClick.RemoveAllListeners();
        }
    }
}
