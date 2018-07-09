using System;
using System.Collections.Generic;
using System.Linq;

namespace TrivialBehind
{
    struct StoredBehind
    {
        public Type BehindType;
        public object BehindInstance;
        public object Creator; // e.g. the form instance that created the behind
    }
    public static class TrivialBehinds
    {
        static Dictionary<Type, Type> registeredBehinds = new Dictionary<Type, Type>();
        static List<StoredBehind> createdBehinds = new List<StoredBehind>();

        class BDisposer : IDisposable
        {
            private readonly object obj;
            internal BDisposer(object toDispose)
            {
                this.obj = toDispose;
            }
            public void Dispose()
            {
                createdBehinds.RemoveAll(d => d.BehindInstance == this.obj);
            }
        }
        public static void RegisterBehind<TUi, TBehind>()
        {
            registeredBehinds.Add(typeof(TUi), typeof(TBehind));
        }

        // returns the disposer that removes this from list
        public static IDisposable CreateForUi<TUi>(object creator, TUi ui)
        {
            Type handler;
            var ok = registeredBehinds.TryGetValue(typeof(TUi), out handler);
            if (!ok)
            {
                throw new ArgumentException($"Behind handler for {ui} not found");
            }
            var ctor = handler.GetConstructor(new[] { typeof(TUi) });
            var instance = ctor.Invoke(new[] { (object) ui });
            createdBehinds.Add(
                new StoredBehind
                {
                    BehindType = handler,
                    BehindInstance = instance,
                    Creator = creator
                });
            return new BDisposer(instance);
        }
        // should not be called from form side (since it shouldn't know behind types)
        public static TBehind[] FindBehinds<TBehind>()
        {
            var needle = typeof(TBehind);
            var res = createdBehinds.Where(e => e.BehindType == needle).Select(e => e.BehindInstance).Cast<TBehind>().ToArray();
            return res;
        }

        public static TBehind FindBehindFor<TBehind>(object creator) where TBehind: class =>
            createdBehinds.First(b => b.Creator == creator) as TBehind;   
    }
}
