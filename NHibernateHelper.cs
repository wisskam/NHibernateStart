using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateStart
{
    public sealed class NHibernateHelper
    {
        private static ISession currentSession;
        private static readonly NHibernate.ISessionFactory _sessionFactory;

        static NHibernateHelper()
        {
            _sessionFactory = new Configuration().Configure().BuildSessionFactory();
        }

        public static ISession GetCurrentSession()
        {

            if (currentSession == null)
            {
                currentSession = _sessionFactory.OpenSession();
            }

            return currentSession;
        }

        public static void CloseSession()
        {
            if (currentSession == null)
            {
                return;
            }

            currentSession.Close();
        }

        public static void CloseSessionFactory()
        {
            if (_sessionFactory != null)
            {
                _sessionFactory.Close();
            }
        }
    }
}
