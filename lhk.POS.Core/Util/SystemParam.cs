//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : Untitled Shopping Central
//  @ File Name : GeneralVariable.cs
//  @ Date : 2/22/2013
//  @ Author :  khoatd
//
//

using lhk.POS.Core.Domain;
namespace lhk.POS.Core.Util
{
    public static class SystemParam
    {
        private static bool m_isLogged;

        public static bool IsLogged
        {
            get { return m_isLogged; }
            set { m_isLogged = value; }
        }

        //private static string m_userName;

        //public static string UserName
        //{
        //    get { return m_userName; }
        //    set { m_userName = value; }
        //}

        //private static string m_userId;

        //public static string UserID
        //{
        //    get { return m_userId; }
        //    set { m_userId = value; }
        //}

        //private static string m_userRole;

        //public static string UserRole
        //{
        //    get { return m_userRole; }
        //    set { m_userRole = value; }
        //}

        private static User _currentUser;

        public static User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        private static bool m_isOpenTransShift;

        public static bool IsOpenTransShift
        {
            get { return m_isOpenTransShift; }
            set { m_isOpenTransShift = value; }
        }

        private static bool m_isCreating;

        public static bool IsCreating
        {
            get { return SystemParam.m_isCreating; }
            set { SystemParam.m_isCreating = value; }
        }
        private static bool m_isUpdating;

        public static bool IsUpdating
        {
            get { return SystemParam.m_isUpdating; }
            set { SystemParam.m_isUpdating = value; }
        }

        private static bool m_isRemoteState;

        public static bool IsRemoteState
        {
            get { return SystemParam.m_isRemoteState; }
            set { SystemParam.m_isRemoteState = value; }
        }
    }
}
