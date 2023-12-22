using System;

namespace Glossary.Exceptions
{
    public class EmpthyTermException:Exception
    {
        public EmpthyTermException()
        {
        }

        public EmpthyTermException(string message)
            : base(message)
        {
        }

        public EmpthyTermException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class InvalidTermException : Exception
    {
        public InvalidTermException()
        {
        }

        public InvalidTermException(string message)
            : base(message)
        {
        }

        public InvalidTermException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class EmpthyDefinitionException : Exception
    {
        public EmpthyDefinitionException()
        {
        }

        public EmpthyDefinitionException(string message)
            : base(message)
        {
        }

        public EmpthyDefinitionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class InvalidDefinitionException : Exception
    {
        public InvalidDefinitionException()
        {
        }

        public InvalidDefinitionException(string message)
            : base(message)
        {
        }

        public InvalidDefinitionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class UniqueTermException : Exception
    {
        public UniqueTermException()
        {
        }

        public UniqueTermException(string message)
            : base(message)
        {
        }

        public UniqueTermException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class RowNotSelectedException:Exception
    {
        public RowNotSelectedException()
        {
        }

        public RowNotSelectedException(string message)
            : base(message)
        {
        }

        public RowNotSelectedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
