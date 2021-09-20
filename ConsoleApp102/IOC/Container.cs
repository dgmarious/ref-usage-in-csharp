using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleApp102.IOC

#region Do NOT USE THIS IN YOUR PROLECT. USE STRUCTUREMAP OR OTHER 

//This is a makeshift dependency injection used for the purpose of this demo.
//Use any other mature Dependency Injection tool like structuremap instead.


#endregion
{
    public class Container
    {
        public static T CreateInstance<T>()
        {
            var type = typeof(T);

            var constructor = type.GetConstructors()[0];

          

            var parameters = constructor.GetParameters();
            if (parameters.Length >0)
            {
                var args = GetDependencies(parameters);

                return (T)constructor.Invoke(args.ToArray());
            }

            return (T)constructor.Invoke( null);

        }


        private static List<object> GetDependencies(ParameterInfo[] parameters)
        {
            List<object> types = new List<object>();

            foreach (var args in parameters)
            {
                //if (args.ParameterType.IsInterface)
                //{
                    var definedTypes = Assembly.GetEntryAssembly().DefinedTypes;

                    var t = definedTypes.FirstOrDefault(x => x.IsClass && args.ParameterType.IsAssignableFrom(x));
                    if (t == null)
                    {
                        throw new InvalidOperationException($"There is no implementation for  {args.Name}");
                    }

                    if (t.GetConstructors()[0].GetParameters().Any())
                    {
                        var members = GetDependencies(t.GetConstructors()[0].GetParameters());
                        types.Add((object)Activator.CreateInstance(t, members.ToArray()));
                    }

                    else{types.Add((object)Activator.CreateInstance(t, null));}
                //}
            }

            return types;
        }
    }
}