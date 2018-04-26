using System;

namespace EjemploApi.Common.Logic.Logger
{
    public interface ILogger
    {
        void Debug(string message);
        void Error(string message);
        void Exception(Exception exception, string message);
        void Exception(Exception exception);
    }
}