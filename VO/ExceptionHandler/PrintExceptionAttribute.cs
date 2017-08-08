using System;
using System.Reflection;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace VO.ExceptionHandler
{
    /// <summary>
    /// Configuracion de aspecto para logeo con postsharp
    /// </summary>
    [PSerializable]
    public class PrintExceptionAttribute : OnExceptionAspect
    {
        Type type;

        public PrintExceptionAttribute()
            : this(typeof(Exception))
        { }

        public PrintExceptionAttribute(Type type)
            : base()
        {
            this.type = type;
        }

        // Method invoked at build time.
        // Should return the type of exceptions to be handled. 
        public override Type GetExceptionType(MethodBase method)
        {
            return this.type;
        }


        public override void OnException(MethodExecutionArgs args)
        {
            VO.Utils.LogRegister.RegisterLog(args.Exception);
        }
    }
}
