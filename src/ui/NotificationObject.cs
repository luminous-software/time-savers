using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Luminous.Code.Core
{
    public class NotificationObject : INotifyPropertyChanged
    {
        private readonly Dictionary<string, object> _properties = new Dictionary<string, object>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected T Get<T>([CallerMemberName] string name = null)
        {
            if (_properties.TryGetValue(name, out var value))
                return (value == null) ? default(T) : (T)value;

            return default(T);
        }

        protected bool Set<T>(T value, [CallerMemberName] string name = null, params Expression<Func<object>>[] additonal)
        {
            if (Equals(value, Get<T>(name)))
                return false;

            _properties[name] = value;
            OnPropertyChanged(name);

            foreach (var item in additonal)
                OnPropertyChanged(item);

            return true;
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected void OnPropertyChanged<T>(Expression<Func<T>> selectorExpression)
        {
            if (selectorExpression == null)
                throw new ArgumentNullException(nameof(selectorExpression));

            var me = selectorExpression.Body as MemberExpression;

            // Nullable properties can be nested inside of a convert function
            if (me == null)
            {
                if (selectorExpression.Body is UnaryExpression ue)
                    me = ue.Operand as MemberExpression;
            }

            if (me == null)
                throw new ArgumentException("The body must be a member expression");

            OnPropertyChanged(me.Member.Name);
        }
    }
}