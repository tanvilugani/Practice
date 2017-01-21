using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContainterDemo
{
    class Resolver
    {
        /// <summary>
        /// Will include business logic for deciding if a master credit card or Visa Credit card.
        /// </summary>
        /// <returns></returns>
        //public ICreditCard ResolveCreditCard()
        //{
        //    if (new Random().Next(2) == 1)
        //        return new MasterCard();

        //    return new VisaCard();
        //}

        private Dictionary<Type, Type> _dependencyMap = new Dictionary<Type, Type>();

        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        private object Resolve(Type typeToResolve)
        {
            Type resolvedType = null;

            try
            {
                resolvedType = _dependencyMap[typeToResolve];
            }
            catch (Exception)
            {
                throw new Exception("Could not resolve type");
                throw;
            }

            var firstConstructor = resolvedType.GetConstructors().First();
            var constructorParameters = firstConstructor.GetParameters();

            if (constructorParameters.Count() == 0)
                return Activator.CreateInstance(resolvedType);

            var parameters = new List<object>();

            foreach (var parametersToResolve in constructorParameters)
            {
                parameters.Add(Resolve(parametersToResolve.ParameterType));
            }

            return firstConstructor.Invoke(parameters.ToArray());
        }

        internal void Register<T1, T2>()
        {
            _dependencyMap.Add(typeof(T1), typeof(T2));
        }
    }
}
