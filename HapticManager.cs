﻿using System.Runtime.InteropServices;

namespace HapticPlugin
{
    /// <summary>
    /// Завязано больше на UI действия
    /// уведомляя пользователя, что он сделал
    /// что-то правильно или предупреждая о последствиях
    /// </summary>
    [System.Serializable]
    public enum NotificationFeedback
    {
        Success,
        Warning,
        Error
    }

    /// <summary>
    /// Степени силы выбрации из категории Impact
    /// Рисунок вибрации одинаковый, отличается только сила
    /// </summary>
    [System.Serializable]
    public enum ImpactFeedback
    {
        Light,
        Medium,
        Heavy
    }

    public static class HapticManager
    {

        public static void Notification(NotificationFeedback feedback)
        {
            _unityTapticNotification((int)feedback);
        }

        public static void Impact(ImpactFeedback feedback)
        {
            _unityTapticImpact((int)feedback);
        }

        public static void Selection()
        {
            _unityTapticSelection();
        }

        public static bool IsSupport()
        {
            return _unityTapticIsSupport();
        }

        #region DllImport

#if UNITY_IPHONE && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void _unityTapticNotification(int type);
        [DllImport("__Internal")]
        private static extern void _unityTapticSelection();
        [DllImport("__Internal")]
        private static extern void _unityTapticImpact(int style);
        [DllImport("__Internal")]
        private static extern bool _unityTapticIsSupport();
#else
        private static void _unityTapticNotification(int type) { }

        private static void _unityTapticSelection() { }

        private static void _unityTapticImpact(int style) { }

        private static bool _unityTapticIsSupport() { return false; }
#endif

        #endregion // DllImport
    }

}