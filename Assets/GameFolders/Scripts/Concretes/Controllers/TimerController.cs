using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameFolders.Scripts.Concretes.Controllers
{
    public class TimerController : MonoBehaviour
    {
        [SerializeField] private Image _timerImage;
        [SerializeField] private float _duration;

        public static float _currentTime { get; set; }
    
        private void OnEnable()
        {
            _currentTime = 0;
        }

        private void Update()
        {
            _timerImage.fillAmount = _currentTime;
            _currentTime += Time.deltaTime/_duration;
        }
    }
}

